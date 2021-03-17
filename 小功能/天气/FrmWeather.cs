using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QQ2020
{
    public partial class FrmWeather : Form
    {
        public FrmWeather()
        {
            InitializeComponent();
        }

        private void Weather_Load(object sender, EventArgs e)
        {
            UpGrade(city);

            
        }

        string city = "成都";

        void setImage(string tianqi)
        {
            Image leiyu = Image.FromFile(@"../../img/雷雨.gif");
            Image yintian = Image.FromFile(@"../../img/阴天.gif");
            Image qingtian = Image.FromFile(@"../../img/晴天.gif");
            if (tianqi.Contains("阴"))
            {
                //BackLab.Image = leiyu;
                this.BackgroundImage = yintian;
            }
            if (tianqi.Contains("雨"))
            {
                //BackLab.Image = leiyu;
                this.BackgroundImage = leiyu;
            }
            if (tianqi.Contains("晴") || tianqi.Contains("云"))
            {
                //BackLab.Image = qingtian;
                this.BackgroundImage = qingtian;
            }


        }

        Image getIcon(string tianqi)
        {
            Image qing = Image.FromFile(@"../../img/晴天.png");
            Image yin = Image.FromFile(@"../../img/阴天.png");
            Image yu = Image.FromFile(@"../../img/雷雨.png");
            Image yun = Image.FromFile(@"../../img/多云转晴.png");
            if (tianqi.Contains("阴"))
            {
                return yin;
            }
            if (tianqi.Contains("雨"))
            {
                return yu;
            }
            if (tianqi.Contains("晴"))
            {
                return qing;
            }
            if (tianqi.Contains("云"))
            {
                return yun;
            }
            else
            {
                return yun;
            }
        }


        void UpGrade(string city)
        {
            System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12; //加上这一句
            //我们的接口
            string url = "https://v0.yiketianqi.com/api?version=v9&appid=32443667&appsecret=qL1ZKMdt";

            System.Net.HttpWebRequest request;
            // 创建一个HTTP请求
            request = (System.Net.HttpWebRequest)WebRequest.Create(url);
            //request.Method="get";
            System.Net.HttpWebResponse response;
            response = (System.Net.HttpWebResponse)request.GetResponse();
            System.IO.StreamReader myreader = new System.IO.StreamReader(response.GetResponseStream(), Encoding.UTF8);
            string getJson = myreader.ReadToEnd();
            myreader.Close();

                JObject jObj = JObject.Parse(getJson);
                JArray data = JArray.Parse(jObj["data"].ToString());
                JArray win = JArray.Parse(data[0]["win"].ToString());

                labelWenDu.Text = data[0]["tem"].ToString();
                labelcity.Text = jObj["city"].ToString();

                labelTianQI.Text = data[0]["wea_day"].ToString();
                //设置背景
                setImage(data[0]["wea_day"].ToString());

                labelFeng.Text = win[0].ToString();
                labelKongQi.Text = "空气" + data[0]["air_level"].ToString();
                labelAir.Text = data[0]["air"].ToString();

                labelTem1.Text = data[0]["tem2"].ToString() + "/" + data[0]["tem1"].ToString() + "°C";
                labelTem2.Text = data[1]["tem2"].ToString() + "/" + data[1]["tem1"].ToString() + "°C";
                labelTem3.Text = data[2]["tem2"].ToString() + "/" + data[2]["tem1"].ToString() + "°C";

                picday1.BackgroundImage = getIcon(data[0]["wea_day"].ToString());
                picday2.BackgroundImage = getIcon(data[1]["wea_day"].ToString());
                picday3.BackgroundImage = getIcon(data[2]["wea_day"].ToString());

            //设置背景动图
            //labelWenDu.Parent = BackLab;
        }
    }
}