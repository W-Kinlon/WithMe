using System;using System.Collections.Generic;using System.ComponentModel;using System.Data;using System.Drawing;using System.Linq;using System.Net;using System.Net.Sockets;using System.Runtime.InteropServices;using System.Text;using System.Threading.Tasks;using System.Windows.Forms;namespace QQ2020{
    /// <summary>    /// TCP套接字传输的数据结构体    /// </summary>    [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]    public struct DataPack    {
        //字符串，SizeConst为字符串的最大长度
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 20)]        public string _sender;//发送方的名称
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 20)]        public string _receiver;//接收方的名称
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 20)]        public string _time;//发送的时间
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 900)]        public string _message;//发送的消息
                               //结构体里的构造函数必须是带参数的
        public DataPack(string s, string r, string t, string m)        {            _sender = s;            _receiver = r;            _time = t;            _message = m;        }    }
    public partial class FrmChat : Form    {        private string friendName;        private string myName;        public FrmChat(string friendName)        {            InitializeComponent();            this.friendName = friendName;            this.labName.Text = friendName;            myName = FrmMain.loginName;            this.Text = friendName;        }
        /// <summary>        /// DataPack结构体转byte数组        /// </summary>        /// <param name="structObj">要转换的结构体</param>        /// <returns>转换后的byte数组</returns>        public static byte[] DataPackToBytes(object structObj)        {
            //得到结构体的大小
            int size = Marshal.SizeOf(structObj);
            //创建byte数组
            byte[] bytes = new byte[size];
            //分配结构体大小的内存空间
            IntPtr structPtr = Marshal.AllocHGlobal(size);
            //将结构体拷到分配好的内存空间
            Marshal.StructureToPtr(structObj, structPtr, false);
            //从内存空间拷到byte数组
            Marshal.Copy(structPtr, bytes, 0, size);
            //释放内存空间
            Marshal.FreeHGlobal(structPtr);
            //返回byte数组
            return bytes;        }
        /// <summary>        /// byte数组转DataPack结构体        /// </summary>        /// <param name="bytes">byte数组</param>        /// <param name="type">结构体类型</param>        /// <returns>转换后的结构体</returns>        public static DataPack BytesToDataPack(byte[] bytes)        {            DataPack dataPack = new DataPack();
            //得到结构体的大小
            int size = Marshal.SizeOf(dataPack);
            //分配结构体大小的内存空间
            IntPtr structPtr = Marshal.AllocHGlobal(size);
            //将byte数组拷到分配好的内存空间
            Marshal.Copy(bytes, 0, structPtr, size);
            //将内存空间转换为目标结构体
            dataPack = (DataPack)Marshal.PtrToStructure(structPtr, dataPack.GetType());
            //释放内存空间
            Marshal.FreeHGlobal(structPtr);
            //去掉两端空格
            dataPack._sender = dataPack._sender.Trim();            dataPack._receiver = dataPack._receiver.Trim();            dataPack._time = dataPack._time.Trim();            dataPack._message = dataPack._message.Trim();
            //返回结构体
            return dataPack;        }        public static void ByteArrayToStructure(byte[] bytes, ref object obj)        {            int size = Marshal.SizeOf(obj);            IntPtr structPtr = Marshal.AllocHGlobal(size);
            // 从结构体指针构造结构体
            obj = Marshal.PtrToStructure(structPtr, obj.GetType());            try            {
                // 将字节数组复制到结构体指针
                Marshal.Copy(bytes, 0, structPtr, size);            }            catch (Exception ex) { Console.WriteLine("ByteArrayToStructure FAIL: error " + ex.ToString()); }            obj = Marshal.PtrToStructure(structPtr, obj.GetType());            Marshal.FreeHGlobal(structPtr);  //释放内存，与 AllocHGlobal() 对应

        }        private void picClose_Click(object sender, EventArgs e)        {            this.Hide();            ToolTip p = new ToolTip();            p.ShowAlways = true;            p.SetToolTip(this.picClose, "关闭");        }        private void picMax_Click(object sender, EventArgs e)        {            if (this.WindowState == FormWindowState.Maximized)            {
                // 如果窗口已经最大化，则恢恢复为正常大小
                this.WindowState = FormWindowState.Normal;                labName.Location = new Point(332, 10);                picKongJian.Location = new Point(401, 11);            }            else            {
                // 否则，窗口为正常时，将其最大化
                //this.WindowState = FormWindowState.Maximized;
                this.WindowState = FormWindowState.Maximized;                labName.Location = new Point(this.Width / 2, 16);                picKongJian.Location = new Point(labName.Location.X + labName.Width + 10, 16);            }        }        private void picMin_Click(object sender, EventArgs e)        {            this.WindowState = FormWindowState.Minimized;        }        private void btnSend_Click(object sender, EventArgs e)        {            string msg = rtbChat.Text;            if (msg.Length == 0)            {                ToolTip toolTip = new ToolTip();                toolTip.ShowAlways = true;//tips
                toolTip.SetToolTip(this.btnSend, "发送消息不能为空");            }            else            {                DateTime dateTime = DateTime.Now.ToLocalTime();                string time = dateTime.ToString();                DataPack dataPack = new DataPack(myName, friendName, time, msg);
                //把结构体数据转为字节数组,发送到服务端、显示到聊天框
                FrmMain.tcpClient.Send(DataPackToBytes(dataPack));                addLabel(myName, time, msg);


                //保存聊天记录至数据库
                string sql = "insert qqchat(sendID,ReceiveID,text,time) VALUES(" +
                    "(select email from qquser where name='" +
                    myName +
                    "')," +
                    "(select email from qquser where name='" +
                    friendName +
                    "')," +
                    "'" +
                    msg +
                    "'," +   //向新添加的用户发送消息
                    "'" +
                    DateTime.Now +            //发送时间
                    "'" +
                    ")";
                var reader = mysqlDB.Edit(sql);                rtbChat.Text = null;//清除输入框的信息
            }        }

        /// <summary>        /// 在富文本框中显示消息        /// </summary>        public void addLabel(string name, string time, string msg)        {            Label lab1 = new Label();            lab1.Font = new Font("微软雅黑", 8);            lab1.Width = 800;            lab1.Height = 20;            lab1.Text = name + "(" + time + ")" + ":";            if (name.Equals(friendName))
            {
                lab1.ForeColor = Color.Blue;            }            else if (name.Equals(myName))
            {
                lab1.ForeColor = Color.Green;            }                        this.flowLP_Chat.Controls.Add(lab1);

            Label lab2 = new Label();            lab2.Font = new Font("微软雅黑", 15);            lab2.Width = 800;            lab2.Height = 35;            lab2.Text = msg;            lab2.ForeColor = Color.Black;            this.flowLP_Chat.Controls.Add(lab2);

            //自动滚到最底部
            flowLP_Chat.AutoScrollPosition = new Point(this.flowLP_Chat.HorizontalScroll.Minimum, this.flowLP_Chat.VerticalScroll.Maximum);

        }







        /// <summary>        /// 定义一个代理        /// </summary>        private delegate void showDialogDelegate(FrmChat Chat, DataPack Pack);

        /// <summary>        /// 在对应的FrmChat窗体对象内显示接收的TCP数据        /// </summary>        public void showDialog(FrmChat frmChat, DataPack dataPack)        {            if (frmChat.flowLP_Chat.InvokeRequired == false) //如果调用该函数的线程和控件flowLP_Chat位于同一个线程内
            {                frmChat.addLabel(dataPack._sender, dataPack._time, dataPack._message);            }            else //如果调用该函数的线程和控件flowLP_Chat不在同一个线程
            {
                //通过使用Invoke的方法，让子线程告诉窗体线程来完成相应的控件操作
                showDialogDelegate deleg = new showDialogDelegate(showDialog);
                //使用控件flowLP_Chat的Invoke方法执行deleg代理
                frmChat.flowLP_Chat.Invoke(deleg, frmChat, dataPack);            }        }        private void picMin_MouseEnter(object sender, EventArgs e)        {            PictureBox pictureBox = (PictureBox)sender;            pictureBox.BackColor = Color.Gray;            ToolTip p = new ToolTip();            p.ShowAlways = true;            p.SetToolTip(this.picMin, "最小化");        }        private void picMin_MouseLeave(object sender, EventArgs e)        {            PictureBox pictureBox = (PictureBox)sender;            pictureBox.BackColor = Color.Transparent;//变透明
        }        private void picMax_MouseEnter(object sender, EventArgs e)        {            PictureBox pictureBox = (PictureBox)sender;            pictureBox.BackColor = Color.Gray;            ToolTip p = new ToolTip();            p.ShowAlways = true;            p.SetToolTip(this.picMax, "最大化");        }        private void picMax_MouseLeave(object sender, EventArgs e)        {            PictureBox pictureBox = (PictureBox)sender;            pictureBox.BackColor = Color.Transparent;//变透明
        }        private void picClose_MouseEnter(object sender, EventArgs e)        {            PictureBox pictureBox = (PictureBox)sender;            pictureBox.BackColor = Color.Gray;            ToolTip p = new ToolTip();            p.ShowAlways = true;            p.SetToolTip(this.picClose, "关闭");        }        private void picClose_MouseLeave(object sender, EventArgs e)        {            PictureBox pictureBox = (PictureBox)sender;            pictureBox.BackColor = Color.Transparent;//变透明
        }        private void picChatTool3_Click(object sender, EventArgs e)        {
            //获取当前所有设备窗口的第一个设备窗口的屏幕图像
            Image img = new Bitmap(Screen.AllScreens[0].Bounds.Width, Screen.AllScreens[0].Bounds.Height);            Graphics g = Graphics.FromImage(img);            g.CopyFromScreen(new Point(0, 0), new Point(0, 0), Screen.AllScreens[0].Bounds.Size);
            //传入截图窗口，降低alpha值（透明度）,作为截屏窗口背景
            FrmCutScreen cutScreenBody = new FrmCutScreen(img);            cutScreenBody.Owner = this;//子窗体向父窗体传值时用
            cutScreenBody.Show();        }        public void addImageTOrtbChat(Image img)        {            Bitmap bmp = new Bitmap(img);//获得图片
                                         //保存剪贴板中的RGB值
            string temp = Clipboard.GetText();            Clipboard.SetDataObject(bmp, false);//将图片放在剪贴板中
            if (rtbChat.CanPaste(DataFormats.GetFormat(DataFormats.Bitmap)))            {                rtbChat.Paste();//粘贴图片数据到富文本框
            }            Clipboard.SetText(temp);        }

        MysqlDB mysqlDB;
        private void FrmChat_Load(object sender, EventArgs e)
        {
            mysqlDB = new MysqlDB();
        }
    }}