using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QQ2020
{
    class JsonServer
    {
        public string getJson(string url)
        {
            try
            {
                System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12; //加上这一句
                // 创建一个HTTP请求
                HttpWebRequest request = (System.Net.HttpWebRequest)WebRequest.Create(url);
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                StreamReader myreader = new StreamReader(response.GetResponseStream(), Encoding.UTF8);
                string json = myreader.ReadToEnd();
                myreader.Close();
                return json;
            }
            catch (System.Net.WebException)
            {
                MessageBox.Show("出现网络连接问题");
                return null;
            }

        }
    }
}
