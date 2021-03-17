﻿using System;
    /// <summary>
        //字符串，SizeConst为字符串的最大长度
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 20)]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 20)]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 20)]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 900)]
                               //结构体里的构造函数必须是带参数的
        public DataPack(string s, string r, string t, string m)
    public partial class FrmChat : Form
        /// <summary>
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
            return bytes;
        /// <summary>
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
            dataPack._sender = dataPack._sender.Trim();
            //返回结构体
            return dataPack;
            // 从结构体指针构造结构体
            obj = Marshal.PtrToStructure(structPtr, obj.GetType());
                // 将字节数组复制到结构体指针
                Marshal.Copy(bytes, 0, structPtr, size);

        }
                // 如果窗口已经最大化，则恢恢复为正常大小
                this.WindowState = FormWindowState.Normal;
                // 否则，窗口为正常时，将其最大化
                //this.WindowState = FormWindowState.Maximized;
                this.WindowState = FormWindowState.Maximized;
                toolTip.SetToolTip(this.btnSend, "发送消息不能为空");
                //把结构体数据转为字节数组,发送到服务端、显示到聊天框
                FrmMain.tcpClient.Send(DataPackToBytes(dataPack));


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
                var reader = mysqlDB.Edit(sql);
            }

        /// <summary>
            {
                lab1.ForeColor = Color.Blue;
            {
                lab1.ForeColor = Color.Green;

            Label lab2 = new Label();

            //自动滚到最底部
            flowLP_Chat.AutoScrollPosition = new Point(this.flowLP_Chat.HorizontalScroll.Minimum, this.flowLP_Chat.VerticalScroll.Maximum);

        }







        /// <summary>

        /// <summary>
            {
            {
                //通过使用Invoke的方法，让子线程告诉窗体线程来完成相应的控件操作
                showDialogDelegate deleg = new showDialogDelegate(showDialog);
                //使用控件flowLP_Chat的Invoke方法执行deleg代理
                frmChat.flowLP_Chat.Invoke(deleg, frmChat, dataPack);
        }
        }
        }
            //获取当前所有设备窗口的第一个设备窗口的屏幕图像
            Image img = new Bitmap(Screen.AllScreens[0].Bounds.Width, Screen.AllScreens[0].Bounds.Height);
            //传入截图窗口，降低alpha值（透明度）,作为截屏窗口背景
            FrmCutScreen cutScreenBody = new FrmCutScreen(img);
            cutScreenBody.Show();
                                         //保存剪贴板中的RGB值
            string temp = Clipboard.GetText();
            if (rtbChat.CanPaste(DataFormats.GetFormat(DataFormats.Bitmap)))
            }

        MysqlDB mysqlDB;
        private void FrmChat_Load(object sender, EventArgs e)
        {
            mysqlDB = new MysqlDB();
        }
    }