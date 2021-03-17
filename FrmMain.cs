using MySql.Data.MySqlClient;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QQ2020
{
    public partial class FrmMain : Form
    {
        Point FrmMainPosition;
        public static string loginName = FrmLogin.loginName;
        //string为好友昵称，List<OneWord>为相关聊天记录List,List中最后一条为最新消息
        public static Dictionary<string, List<OneWord>> dicChats;//聊天记录字典
        public static Dictionary<string, MessageList> dicChatLists;//MessageList字典
        public static Dictionary<string, FrmChat> frmChats;//聊天窗口字典
        public static Socket tcpClient;//与聊天服务器的套接字链接
        private string serverAdress = "49.232.24.236";//服务端IP地址49.232.24.236
        private int serverPoint = 3002;//服务端的端口号
        MysqlDB mysqlDB;//调用mysql服务
        MySqlDataReader res;//数据库返回值


        public FrmMain()
        {
            InitializeComponent();
            FrmMainPosition = new Point();
        }
        //记录鼠标起始位置
        private void FrmMain_MouseDown(object sender, MouseEventArgs e)
        {
            FrmMainPosition.X = e.X;
            FrmMainPosition.Y = e.Y;
        }
        private void FrmMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point h_myPosition = MousePosition;
                h_myPosition.Offset(-FrmMainPosition.X, -FrmMainPosition.Y);
                Location = h_myPosition;
            }
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            //初始化全局变量
            mysqlDB = new MysqlDB();
            dicChatLists = new Dictionary<string, MessageList>();
            dicChats = new Dictionary<string, List<OneWord>>();
            frmChats = new Dictionary<string, FrmChat>();


            labName.Text = User.Name;//从类的静态字段中取值
            //从服务器拉取所有与本用户相关的聊天记录，存储到聊天记录字典
            //sql语句（谨慎使用drop，delete!!!）
            string sql = "SELECT * FROM qqchatView WHERE rname='"+ loginName + "' OR sname='" + loginName + "' ORDER BY time ASC";
            //接口sql=SELECT * FROM qqchatView WHERE rname='yiki' OR sname='yiki' ORDER BY time ASC

            res = mysqlDB.Get(sql);
            while(res.Read())
            {
                string _sender = res.GetString("sname"); ;//发送者
                string _receiver = res.GetString("rname");//接收者
                DateTime _time = res.GetDateTime("time");//发送时间
                //_time = _time.AddHours(-8);    //加时间(时区转换)
                string _text = res.GetString("text");//发送内容
                string _friend;//该条记录的好友昵称
                OneWord word = new OneWord();
                word.Time = _time;
                word.Text = _text;
                if (_sender.Equals(loginName))
                {
                    word.Sender = true;
                    _friend = _receiver;
                }
                else
                {
                    word.Sender = false;
                    _friend = _sender;
                }
                if (DicChats.ContainsKey(_friend))
                {
                    DicChats[_friend].Add(word);//该好友目录下增加一条聊天记录
                }
                else
                {//增加一条好友目录
                    List<OneWord> words = new List<OneWord>();
                    words.Add(word);
                    DicChats.Add(_friend, words);
                }
            }

            //将最新一条聊天记录显示到聊天记录列表控件中
            //反向遍历数组
            for(int i= DicChats.Count()-1; i>=0;i--)
            {
                var data = DicChats.ToArray()[i];
                MessageList messageList = new MessageList();
                messageList.ContactsName = data.Key.ToString();
                messageList.LastMsg = data.Value.Last().Text;
                messageList.LastMsgSendTime = data.Value.Last().Time.TimeOfDay.ToString();
                flowLayoutPanelMessage.Controls.Add(messageList);
                dicChatLists.Add(messageList.ContactsName, messageList);
            }
            //创建TCP套接字，发起连接请求
            try
            {
                tcpClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                IPAddress ipaddress = IPAddress.Parse(serverAdress);
                EndPoint point = new IPEndPoint(ipaddress, serverPoint);
                tcpClient.Connect(point);//通过IP和端口号，定位一个要连接到的服务端
                                         //向服务端发送初始化消息以表明自己身份
                DataPack dataPack = new DataPack(loginName, "server", "server", "server");
                tcpClient.Send(FrmChat.DataPackToBytes(dataPack));
                //创建线程，一直接收服务端发来的数据
                ThreadStart _receiveThread = new ThreadStart(receiveThread);
                Thread _childThread = new Thread(_receiveThread);
                _childThread.Start();
            }
            catch(Exception) {
                MessageBox.Show("服务器无响应，请稍后再试");
                System.Environment.Exit(0);
            }

        }
        
        public void receiveThread()
        {
            while (true)
            {
                byte[] buffer = new byte[1024];
                tcpClient.Receive(buffer, 0, buffer.Length, SocketFlags.None);
                DataPack dataPack = FrmChat.BytesToDataPack(buffer);
                if (frmChats.ContainsKey(dataPack._sender))
                {
                    //获取发送者的对应聊天窗体
                    FrmChat frmChat = FrmMain.frmChats[dataPack._sender];
                    //在对应的FrmChat窗体对象内显示接收的TCP数据
                    frmChat.showDialog(frmChat, dataPack);
                }
                else
                {
                    lastMsg(dataPack);
                }
            }
        }
        public void lastMsg(DataPack dataPack)
        {
            //保存接收的信息到字典,刷新聊天列表并发出提示音
            if (dataPack._time != "") {
                OneWord word = new OneWord();
                word.Time = Convert.ToDateTime(dataPack._time);
                word.Text = dataPack._message;
                word.Sender = false;
                if (DicChats.ContainsKey(dataPack._sender))
                {
                    DicChats[dataPack._sender].Add(word);//该好友目录下增加一条聊天记录
                                                         //刷新消息
                    dicChatLists[dataPack._sender].refresh(dicChatLists[dataPack._sender], dataPack._time, dataPack._message);
                }
                else
                {
                    List<OneWord> words = new List<OneWord>();
                    words.Add(word);
                    DicChats.Add(dataPack._sender, words);//增加一条好友目录
                    MessageList messageList = new MessageList();
                    messageList.ContactsName = dataPack._sender;
                    messageList.LastMsg = dataPack._message;
                    messageList.LastMsgSendTime = dataPack._time;
                    flowLayoutPanelMessage.Controls.Add(messageList);
                    dicChatLists.Add(messageList.ContactsName, messageList);
                    messageList.refresh(messageList, dataPack._time, dataPack._message);
                }
            } 
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Close();
            System.Environment.Exit(0);
        }

            private void picMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void picAdd_Click(object sender, EventArgs e)
        {

        }

        private void picClose_MouseEnter(object sender, EventArgs e)
        {
            picClose.BackColor = Color.Gray;
        }

        private void picClose_MouseLeave(object sender, EventArgs e)
        {
            ToolTip p = new ToolTip();
            p.ShowAlways = true;
            p.SetToolTip(this.picClose, "关闭");
            picClose.BackColor = Color.Transparent;
        }

        private void picAdd_MouseEnter(object sender, EventArgs e)
        {

            picAdd.BackColor = Color.Gray;
        }

        private void picAdd_MouseLeave(object sender, EventArgs e)
        {
            ToolTip p = new ToolTip();
            p.ShowAlways = true;
            p.SetToolTip(this.picAdd, "界面管理器");
            picAdd.BackColor = Color.Transparent;
        }

        private void picMin_MouseEnter(object sender, EventArgs e)
        {
            picMin.BackColor = Color.Gray;
            ToolTip p = new ToolTip();
            p.ShowAlways = true;
            p.SetToolTip(this.picMin, "最小化");
        }

        private void picMin_MouseLeave(object sender, EventArgs e)
        {
            picMin.BackColor = Color.Transparent;
        }

        private void picEmail_MouseEnter(object sender, EventArgs e)
        {
            picEmail.BackColor = Color.Gray;
            ToolTip p = new ToolTip();
            p.ShowAlways = true;
            p.SetToolTip(this.picEmail, "邮箱");
        }

        private void picEmail_MouseLeave(object sender, EventArgs e)
        {
            picEmail.BackColor = Color.Transparent;
        }

        private void picHonor_MouseEnter(object sender, EventArgs e)
        {
            picHonor.BackColor = Color.Gray;
            ToolTip p = new ToolTip();
            p.ShowAlways = true;
            p.SetToolTip(this.picHonor, "勋章");
        }

        private void picHonor_MouseLeave(object sender, EventArgs e)
        {
            picHonor.BackColor = Color.Transparent;
        }

        private void picClothes_MouseEnter(object sender, EventArgs e)
        {
            picClothes.BackColor = Color.Gray;
            ToolTip p = new ToolTip();
            p.ShowAlways = true;
            p.SetToolTip(this.picClothes, "个性装扮");
        }

        private void picClothes_MouseLeave(object sender, EventArgs e)
        {
            picClothes.BackColor = Color.Transparent;
        }

        private void picZone_MouseEnter(object sender, EventArgs e)
        {
            picZone.BackColor = Color.Gray;
            ToolTip p = new ToolTip();
            p.ShowAlways = true;
            p.SetToolTip(this.picZone, "QQ空间");
        }

        private void picZone_MouseLeave(object sender, EventArgs e)
        {
            picZone.BackColor = Color.Transparent;
        }

        FrmWeather weather = new FrmWeather();
        private void picWeather_MouseEnter(object sender, EventArgs e)
        {
            picWeather.Image = Image.FromFile(@"../../img/大太阳.png");
            ToolTip p = new ToolTip();
            p.ShowAlways = true;
            p.SetToolTip(this.picWeather, "天气");

            weather.Location = new Point(this.Location.X - weather.Width - 10, this.Location.Y + 50);
            weather.Show();
        }

        private void picWeather_MouseLeave(object sender, EventArgs e)
        {
            picWeather.Image = Image.FromFile(@"../../img/小太阳.png");
            weather.Hide();
        }

        private void ToDraw_Click(object sender, EventArgs e)
        {
            new QQ2020.FormTuYa().Show();

        }

        private Point point;
        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
            point = new Point(e.X, e.Y);
        }

        private void panelTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Location = new Point(this.Location.X + e.X - point.X,
                    this.Location.Y + e.Y - point.Y);
            }
        }

        private void picRank_Click(object sender, EventArgs e)
        {

        }
        MyMusicBox.fraMusicBox fraMusicBox;

        internal Dictionary<string, List<OneWord>> DicChats { get => dicChats; set => dicChats = value; }

        private void ToMusic_Click(object sender, EventArgs e)
        {
            fraMusicBox = new MyMusicBox.fraMusicBox();
            fraMusicBox.Show();
        }

        private void ToDraw_MouseEnter(object sender, EventArgs e)
        {
            ToolTip p = new ToolTip();
            p.ShowAlways = true;
            p.SetToolTip(this.ToDraw, "涂鸦画板");
        }

        private void ToMusic_MouseEnter(object sender, EventArgs e)
        {
            ToolTip p = new ToolTip();
            p.ShowAlways = true;
            p.SetToolTip(this.ToMusic, "音乐盒");
        }

        private void picWeather_Click(object sender, EventArgs e)
        {

        }

        private void AddUser_MouseEnter(object sender, EventArgs e)
        {
            ToolTip p = new ToolTip();
            p.ShowAlways = true;
            p.SetToolTip(this.AddUser, "添加好友");
        }

        private void AddUser_Click(object sender, EventArgs e)
        {
            FrmAddUser frmAddUser = new FrmAddUser();
            frmAddUser.Show();
        }

        public void picRefrsh_Click(object sender, EventArgs e)
        {
            flowLayoutPanelMessage.Controls.Clear();//清空所有控件
            FrmMain_Load(null, null);
        }

        private void picRefrsh_MouseEnter(object sender, EventArgs e)
        {
            ToolTip p = new ToolTip();
            p.ShowAlways = true;
            p.SetToolTip(this.picRefrsh, "刷新列表");
        }
    }

}
