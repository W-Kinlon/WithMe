using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using CCWin;
using CCWin.SkinControl;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QQ2020
{
    public partial class FrmLogin : CCSkinMain
    {
        Point QQLoginPosition;
        public FrmLogin()
        {
            InitializeComponent();
            QQLoginPosition = new Point();
        }

        //记录鼠标起始位置
        private void QQLogin_MouseDown(object sender, MouseEventArgs e)
        {
            QQLoginPosition.X = e.X;
            QQLoginPosition.Y = e.Y;
        }
        //鼠标移动窗体
        private void QQLogin_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point h_myPosition = MousePosition;
                h_myPosition.Offset(-QQLoginPosition.X, -QQLoginPosition.Y);
                Location = h_myPosition;
            }
        }


        private void QQLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (MessageBox.Show("将要关闭，是否继续？", "提示", MessageBoxButtons.YesNo,
            //    MessageBoxIcon.Warning) == DialogResult.Yes)
            //{
            //    e.Cancel = false;
            //}
            //else
            //{
            //    e.Cancel = true;
            //}
        }
        FrmSign frmSign;
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                frmSign = new FrmSign();
                frmSign.Show();
            }
            catch (System.ObjectDisposedException)
            {
                frmSign.Hide();
            }
            
        }

        public void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        public static string loginName;
        MysqlDB mysqlDB;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            mysqlDB = new MysqlDB();
            //FrmChat frmChat = new FrmChat("调试");
            //frmChat.Show();
            //sql语句（谨慎使用drop，delete!!!）
            string sql = "SELECT name,pwd FROM qqUser";
            if (TxtUser.Text.Equals(""))
                MessageBox.Show("用户名不能为空");
            else
            {
                var reader = mysqlDB.Get(sql);
                Dictionary<string, string> qqDict = new Dictionary<string, string>();//qq用户密码字典
                if (reader != null)
                {
                    while (reader.Read())
                    {
                        string name = reader.GetString("name");
                        string pwd = reader.GetString("pwd");
                        qqDict.Add(name, pwd);
                    }

                    if (TxtPas.Text.Equals(""))
                        MessageBox.Show("密码不能为空");
                    else
                    {
                        loginName = TxtUser.Text;
                        User.Name = TxtUser.Text;//将登陆名的text创给类的静态字段
                        if (qqDict.ContainsKey(loginName))
                        {
                            if (TxtPas.Text.Equals(qqDict[TxtUser.Text]))
                            {
                                //MessageBox.Show("密码正确");
                                FrmMain frmMain = new FrmMain();
                                frmMain.Show();
                                this.Hide();
                            }
                            else
                                MessageBox.Show("密码错误");
                        }
                        else
                            MessageBox.Show("无此用户名");
                    }
                }
                else {
                    MessageBox.Show("出现网络连接问题");
                }
                
            }
        }

        private void RePas_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Sign.LinkVisited = true;
            Process.Start("Chrome", "https://aq.qq.com/v2/uv_aq/html/reset_pwd/");
        }
        
        private void QQLogin_Load(object sender, EventArgs e)
        {
            picAddUser.Parent = picBigQQ.Parent = btnSetting.Parent = btnMin.Parent = btnClose.Parent;
            //picBigQQ.Parent = pictureBox1;

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void RePas_MouseEnter(object sender, EventArgs e)
        {
            RePas.LinkColor = Color.Black;//字体变黑
        }

        private void RePas_MouseLeave(object sender, EventArgs e)
        {
            RePas.LinkColor = Color.Gray;//字体变回
        }

        private void Sign_MouseEnter(object sender, EventArgs e)
        {
            Sign.LinkColor = Color.Black;//字体变黑
        }

        private void Sign_MouseLeave(object sender, EventArgs e)
        {
            Sign.LinkColor = Color.Gray;//字体变回
        }

        private void AutoLogin_MouseEnter(object sender, EventArgs e)
        {
            AutoLogin.ForeColor = Color.Black;//字体变黑
        }

        private void AutoLogin_MouseLeave(object sender, EventArgs e)
        {
            AutoLogin.ForeColor = Color.Gray;//字体变回
        }

        private void RemPas_MouseEnter(object sender, EventArgs e)
        {
            RemPas.ForeColor = Color.Black;//字体变黑
        }

        private void RemPas_MouseLeave(object sender, EventArgs e)
        {
            RemPas.ForeColor = Color.Gray;//字体变回
        }
        private void picCode_MouseEnter(object sender, EventArgs e)
        {
            picCode.BackgroundImage = Image.FromFile(@"../../img/tdcode1.png");
            ToolTip p = new ToolTip();
            p.ShowAlways = true;
            p.SetToolTip(this.picCode, "二维码登录");
        }

        private void picCode_MouseLeave(object sender, EventArgs e)
        {
            picCode.BackgroundImage = Image.FromFile(@"../../img/tdcode.png");
        }

        private void picBigQQ_MouseEnter(object sender, EventArgs e)
        {
            if (picAddUser.Location.X == picBigQQ.Location.X)
            {
                timer1.Enabled = true;
                timer1.Start();
                timer1.Interval = 14;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int step;
            //设置step
            if (picAddUser.Location.X < picBigQQ.Location.X + 100)
            {
                step = 5;
            }
            else
            {
                step = 0;
            }

            //加号往右跑
            picAddUser.Location =
                new Point(picAddUser.Location.X + step, picAddUser.Location.Y);

            if (picAddUser.Location.X >= picBigQQ.Location.X + 100)
            {
                timer1.Stop();
            }
        }

        private void picBigQQ_MouseLeave(object sender, EventArgs e)
        {
            //加号停留1.5秒
            timer2.Enabled = true;
            timer2.Start();
            timer2.Interval = 1500;
        }

        private void picAddUser_MouseEnter(object sender, EventArgs e)
        {
            ToolTip p = new ToolTip();
            p.ShowAlways = true;
            p.SetToolTip(this.picAddUser, "添加用户");
            picAddUser.Image = Image.FromFile(@"../../img/add.png");
        }

        private void picAddUser_MouseLeave(object sender, EventArgs e)
        {
            picAddUser.Image = Image.FromFile(@"../../img/addition.png");
        }


        private void timer2_Tick(object sender, EventArgs e)
        {
            if (picAddUser.Location.X <= picBigQQ.Location.X)
            {
                timer2.Stop();
            }
            else
            {
                //加号回去
                timer3.Enabled = true;
                timer3.Start();
                timer3.Interval = 14;
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            int step;
            //设置step
            if (picAddUser.Location.X > picBigQQ.Location.X)
            {
                step = 5;
            }
            else
            {
                step = 0;
            }

            //加号往回
            picAddUser.Location =
                new Point(picAddUser.Location.X - step, picAddUser.Location.Y);

            if (picAddUser.Location.X <= picBigQQ.Location.X)
            {
                timer3.Stop();
            }
        }


        private void picBackground_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_MouseEnter(object sender, EventArgs e)
        {
            ToolTip p = new ToolTip();
            p.ShowAlways = true;
            p.SetToolTip(this.btnClose, "关闭");
        }

        private void btnMin_MouseEnter(object sender, EventArgs e)
        {
            ToolTip p = new ToolTip();
            p.ShowAlways = true;
            p.SetToolTip(this.btnMin, "最小化");
        }

        private void btnSetting_MouseEnter(object sender, EventArgs e)
        {
            ToolTip p = new ToolTip();
            p.ShowAlways = true;
            p.SetToolTip(this.btnSetting, "设置");
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {

        }

        private void TxtPas_IconClick(object sender, EventArgs e)
        {
            TxtPas.IsSystemPasswordChar = true;
            var xx = new CCWin.SkinControl.SkinWaterTextBox();
            xx.UseSystemPasswordChar = true;
            xx.PasswordChar = '*';
            xx.TextChanged += delegate (object senderx, EventArgs ex) { TxtPas.Text = xx.Text; };//new EventHandler(textBox2_TextChanged) ;}
            PassKey pass = new PassKey(this.Left + TxtPas.Left - 25, this.Top + TxtPas.Bottom, xx);
            pass.Show();
        }

        private void TxtPas_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
