
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QQ2020
{
    class MysqlDB
    {
        private string connetStr;
        // server=127.0.0.1/localhost 代表本机，端口号port默认是3306可以不写
        private MySqlConnection conn;

        //带参构造方法
        public MysqlDB(string ip, int port, string DBname, string DBpwd)
        {
            this.connetStr = "server=" + ip +
                ";port=" + port +
                ";user=" + DBname +
                ";password=" + DBpwd +
                "; database=" + DBname +
                ";";
        }

        //无参构造方法
        //无参默认使用
        public MysqlDB()
        {
            this.connetStr = "server=49.232.24.236" +
                ";port=3306" +
                ";user=winform" +
                ";password=123456" +
                "; database=winform" +
                ";";
        }

        //连接方法
        public void Connect()
        {
            conn = new MySqlConnection(connetStr);
            try
            {
                conn.Open();//打开通道，建立连接，可能出现异常,使用try catch语句
                Console.WriteLine("已经建立连接");
                //在这里使用代码对数据库进行增删查改
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show(ex.Message);//打印错误信息
            }
            finally
            {
                //conn.Close();
            }
        }

        //查询方法
        public MySqlDataReader Get(string sql)
        {
            this.Connect();//连接数据库
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader reader = cmd.ExecuteReader();//执行ExecuteReader()返回一个MySqlDataReader对象

                return reader;
            }
            catch (System.InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
                //MessageBox.Show(ex.Message);//打印错误信息
                return null;//操作失败，返回空值
            }

            //返回值使用方法
            //while (reader.Read())//初始索引是-1，执行读取下一行数据，返回值是bool
            // {
            //Console.WriteLine(reader[0].ToString() + reader[1].ToString() + reader[2].ToString());
            //Console.WriteLine(reader.GetInt32(0)+reader.GetString(1)+reader.GetString(2));
            //Console.WriteLine(reader.GetInt32("userid") + reader.GetString("username") + reader.GetString("password"));
            //"userid"是数据库对应的列名，推荐这种方式
            // }
        }

        //操作数据库
        public Boolean Edit(string sql)
        {
            this.Connect();//连接数据库
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader reader = cmd.ExecuteReader();//执行ExecuteReader()返回一个MySqlDataReader对象
                return true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                //MessageBox.Show(ex.Message);//打印错误信息
                return false;
            }

        }
    }
}
