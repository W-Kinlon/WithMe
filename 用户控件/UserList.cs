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
    public partial class UserList : UserControl
    {
        public UserList()
        {
            InitializeComponent();
        }

        string _userName, _userQianming,_userEmail;
        Image _image;


        public Image Image { get => _image; set => _image = value; }
        public string UserName { get => _userName; set => _userName = value; }
        public string UserQianming { get => _userQianming; set => _userQianming = value; }
        public string UserEmail { get => _userEmail; set => _userEmail = value; }

        private void UserList_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.LightSlateGray;
        }

        private void UserList_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void UserList_Click(object sender, EventArgs e)
        {
            MessageBoxButtons mess = MessageBoxButtons.OKCancel;
            DialogResult dr = MessageBox.Show("确定要添加此用户？", "提示", mess);
            if (dr == DialogResult.OK)
            {
                string sql = "insert qqchat(sendID,ReceiveID,text,time) VALUES(" +
                    "(select email from qquser where name='" +
                    FrmLogin.loginName +
                    "')," +
                    "'" +
                    UserEmail +
                    "'," +
                    "'hello 我的新好友'," +   //向新添加的用户发送消息
                    "'"+
                    DateTime.Now +            //发送时间
                     "'"+
                    ")";

                Boolean res = mysqlDB.Edit(sql);
                //MessageBox.Show(getJson);
                if (res)
                {
                    MessageBox.Show("添加成功!");
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("添加失败!");
                }
            }
        }

        MysqlDB mysqlDB;
        private void UserList_Load(object sender, EventArgs e)
        {
            pictureUser.BackgroundImage = Image;
            labelName.Text = UserName;
            labelQianMing.Text = UserQianming;
            labEmail.Text = UserEmail;

            mysqlDB = new MysqlDB();
        }
    }
}
