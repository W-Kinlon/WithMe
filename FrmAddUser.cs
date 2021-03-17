using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QQ2020
{
    public partial class FrmAddUser : Form
    {
        public FrmAddUser()
        {
            InitializeComponent();
        }
        MysqlDB mysqlDB;
        private void FrmAddUser_Load(object sender, EventArgs e)
        {
            //初始化
            mysqlDB = new MysqlDB();
            string sql = "select * from qquser where name!='" + FrmLogin.loginName + "'";
            var reader = mysqlDB.Get(sql);

            while (reader.Read())
            {
                UserList userList = new UserList();
                
                userList.UserName = reader.GetString("name");//用户名
                userList.UserEmail = reader.GetString("email");//邮箱

                flowLayoutPanel1.Controls.Add(userList);
            }
        }

        private void picSearch_MouseEnter(object sender, EventArgs e)
        {
            ToolTip p = new ToolTip();
            p.ShowAlways = true;
            p.SetToolTip(this.picSearch, "查询用户");

            picSearch.BackColor = Color.AliceBlue;
        }

        private void picSearch_Click(object sender, EventArgs e)
        {
            if (textName.Text != "") {
                flowLayoutPanel1.Controls.Clear();
                string sql = "select * from qquser where name='" + textName.Text + "'";
                var reader = mysqlDB.Get(sql);

                if (!reader.HasRows) {
                    while (reader.Read())
                    {
                        UserList userList = new UserList();

                        userList.UserName = reader.GetString("name");//用户名
                        userList.UserEmail = reader.GetString("email");//邮箱

                        flowLayoutPanel1.Controls.Add(userList);
                    }
                }
                else
                {
                    MessageBox.Show("无此用户");
                }
                
            }
            else
            {
                FrmAddUser_Load(null, null);
            }
        }

        private void picSearch_MouseLeave(object sender, EventArgs e)
        {
            picSearch.BackColor = Color.Transparent;
        }
    }
}
