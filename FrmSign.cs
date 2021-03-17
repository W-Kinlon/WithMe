using Newtonsoft.Json.Linq;
using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace QQ2020
{
    public partial class FrmSign : Form
    {
        public FrmSign()
        {
            InitializeComponent();
        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            if (SignName.Text.Equals("") && !MachRegex(@"^[a-zA-Z]\w{1,5}$", SignName.Text))
                MessageBox.Show("用户名错误");
            else
            {
                if (SignPwd.Text.Equals("") && !MachRegex(@"^[a-zA-Z]\w{5,7}$", SignPwd.Text))
                    MessageBox.Show("密码错误");
                else
                {
                    if (!SignPwd.Text.Equals(SignPwd2.Text))
                    {
                        MessageBox.Show("两次密码输入不一致");
                        SignPwd2.Text = "";
                    }

                    else
                    {
                        if (ConfirmCode.Text.Equals(verification_code))
                        {
                            //sql语句（谨慎使用drop，delete!!!）
                            string sql = "INSERT INTO qqUser(name,pwd,email) VALUES (\"" + SignName.Text + "\",\"" +
                                SignPwd2.Text + "\",\"" + SignEmail.Text + "\")";
                            var res = mysqlDB.Edit(sql);

                            //MessageBox.Show(getJson);
                            if (res)
                            {
                                MessageBox.Show("注册成功!");
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("注册失败!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("验证码不正确");
                        }
                    }
                }
            }

        }

        string verification_code;
        private void btnSendCode_Click(object sender, EventArgs e)
        {
            if (!SignEmail.Text.Equals("") && judgeEmailAddress(SignEmail.Text))
            {
                //接口
                string emailSql = "select * FROM qquser WHERE email =" + "\"" + SignEmail.Text + "\"";
                var emailRes = mysqlDB.Get(emailSql);

                //MessageBox.Show(emailRes);
                if (!emailRes.HasRows)
                {
                    string url2 = "https://api.kinlon.work/EmailCode/?to=" + SignEmail.Text;
                    JObject jObj = JObject.Parse(jsonServer.getJson(url2));
                    verification_code = jObj["verification_code"].ToString();
                    if (verification_code != null) {
                        btnSendCode.BackColor = Color.Gray;
                        labCode.Visible = true;
                        timer1.Interval = 1000;
                        timer1.Enabled = true;
                    }
                }
                else
                {
                    MessageBox.Show("邮箱已被注册");
                }
            }
            else
            {
                MessageBox.Show("邮箱输入错误");
            }
        }

        int seconds = 1;
        private void timer1_Tick(object sender, EventArgs e)
        {
            seconds++;
            btnSendCode.Text = seconds.ToString();
            if(seconds%60 == 0)
            {
                btnSendCode.BackColor = Color.Teal;
                btnSendCode.Text = "重发";
                timer1.Enabled = false;
            }
        }


        private static bool MachRegex(string regex, string str)
        {
            Regex reg = new Regex(regex);
            return reg.IsMatch(str);
        }

        static public bool judgeEmailAddress(string emailAddress)
        {
            //有“@”
            if (emailAddress.IndexOf("@") == -1)
            {
                Console.WriteLine("输入的字符串中 没有@ ！");
                return false;
            }

            //只有一个“@”
            if (emailAddress.IndexOf("@") != emailAddress.LastIndexOf("@"))
            {
                Console.WriteLine("输入的字符串中 有多个@ ！");
                return false;
            }

            //有“.”
            if (emailAddress.IndexOf(".") == -1)
            {
                Console.WriteLine("输入的字符串中 没有.  ！");
                return false;
            }

            //“@”出现在第一个“.”之前
            if (emailAddress.IndexOf("@") > emailAddress.IndexOf("."))
            {
                Console.WriteLine("输入的字符串中 @没有出现在.之前！");
                return false;
            }

            //“@”不可以是第一个元素
            if (emailAddress.StartsWith("@"))
            {
                Console.WriteLine("输入的字符串中 @是第一个元素！");
                return false;
            }

            //“.”不可以是最后一位
            if (emailAddress.EndsWith("."))
            {
                Console.WriteLine("输入的字符串中 .是最后一位！");
                return false;
            }

            //不能出现“@.”
            if (emailAddress.IndexOf("@.") != -1)
            {
                Console.WriteLine("输入的字符串中 出现了@. !");
                return false;
            }

            //不能出现“..”
            if (emailAddress.IndexOf("..") != -1)
            {
                Console.WriteLine("输入的字符串中 出现了.. !");
                return false;
            }
            return true;
        }

        JsonServer jsonServer;
        MysqlDB mysqlDB;
        private void FrmSign_Load(object sender, EventArgs e)
        {
            jsonServer = new JsonServer();
            mysqlDB = new MysqlDB();
        }
    }
}
