using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QQ2020
{
    public partial class MessageList : UserControl
    {

        public MessageList()
        {
            InitializeComponent();
        }

        public string _contactsName;
        public string _lastMsg;
        public string _lastMsgSendTime;
        public string _imgAvatar;

        public string ImgAvatar { get => _imgAvatar; set => _imgAvatar = value; }
        public string LastMsgSendTime { get => _lastMsgSendTime; set => _lastMsgSendTime = value; }
        public string LastMsg { get => _lastMsg; set => _lastMsg = value; }
        public string ContactsName { get => _contactsName; set => _contactsName = value; }

        private void MessageList_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.AliceBlue;
            picTips.BackColor = Color.AliceBlue;
        }

        private void MessageList_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            picTips.BackColor = Color.White;
        }

        private void MessageList_Load(object sender, EventArgs e)
        {
            labelName.Text = _contactsName;
            labelLastMessage.Text = _lastMsg;
            labelLastTime.Text = _lastMsgSendTime;
        }

        public void refresh(MessageList msgComponent, String _lastMsgSendTime, String _lastMsg)
        {
            //刷新消息
            if (msgComponent.labelName.InvokeRequired == false) //如果调用该函数的线程和控件flowLP_Chat位于同一个线程内
            {
                msgComponent._lastMsgSendTime = _lastMsgSendTime;
                msgComponent._lastMsg = _lastMsg;
                msgComponent.labelLastMessage.Text = _lastMsg;
                msgComponent.labelLastTime.Text = _lastMsgSendTime.Substring(11);
                msgComponent.picTips.Visible = true;
                Console.Beep();            }            else //如果调用该函数的线程和控件flowLP_Chat不在同一个线程
            {
                //通过使用Invoke的方法，让子线程告诉窗体线程来完成相应的控件操作
                refreshDelegate deleg = new refreshDelegate(refresh);
                //使用控件flowLP_Chat的Invoke方法执行deleg代理
                msgComponent.labelName.Invoke(deleg, msgComponent, _lastMsgSendTime, _lastMsg);            }
        }
        /// <summary>        /// 定义一个代理        /// </summary>        private delegate void refreshDelegate(MessageList msgComponent, String _lastMsgSendTime, String _lastMsg);

        private void MessageList_DoubleClick(object sender, EventArgs e)
        {
            //打开好友聊天窗口
            if (FrmMain.frmChats.ContainsKey(ContactsName))
            {
                //显示已有的聊天窗口
                FrmMain.frmChats[ContactsName].Show();
            }
            else
            {
                //新建一个聊天窗口
                FrmChat frmChat = new FrmChat(ContactsName);
                frmChat.Show();
                FrmMain.frmChats.Add(ContactsName, frmChat);
                //将聊天记录全部加载到聊天窗口中
                DataPack dataPack;
                string s, r, t, m;
                foreach (var oneWord in FrmMain.dicChats[ContactsName])
                {
                    if (oneWord.Sender == true)
                    {
                        s = FrmMain.loginName;
                        r = ContactsName;
                    }
                    else
                    {
                        r = FrmMain.loginName;
                        s = ContactsName;
                    }
                    t = oneWord.Time.ToString();
                    m = oneWord.Text;
                    dataPack = new DataPack(s, r, t, m);
                    frmChat.showDialog(frmChat, dataPack);
                }
            }
            picTips.Visible = false;
        }
    }
}
