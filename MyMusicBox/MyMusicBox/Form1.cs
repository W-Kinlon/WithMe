using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace MyMusicBox
{
    public partial class fraMusicBox : Form
    {
        public fraMusicBox()
        {
            InitializeComponent();
        }

        public myProgressBar mbp;
        public List<myLabel> mlblsongs;
        myProgressBar mbpVolume;
        List<Label> lblLyric;
        public int mlIndex = -1;
        DoubleBufferPanel dbPanel;
        DoubleBufferPanel pnlVolume;
        private void fraMusicBox_Load(object sender, EventArgs e)
        {
            //将歌词label加入到集合
            lblLyric = new List<Label>();
            lblLyric.Add(lblLyric1);
            lblLyric.Add(lblLyric2);
            lblLyric.Add(lblLyric3);
            lblLyric.Add(lblLyric4);
            lblLyric.Add(lblLyric5);
            lblLyric.Add(lblLyric6);
            lblLyric.Add(lblLyric7);
            lblLyric.Add(lblLyric8);
            lblLyric.Add(lblLyric9);
            lblLyric.Add(lblLyric10);
            lblLyric.Add(lblLyric11);
            lblLyric.Add(lblLyric12);

            pnlVolume = new DoubleBufferPanel();
            pnlVolume.SetBounds(791,542,170,30);
            this.Controls.Add(pnlVolume);
            pnlVolume.Visible = false;

            pnlControl1.BackColor = Color.FromArgb(150, 0, 0, 0);
            pnlControl2.BackColor = Color.FromArgb(150, 0, 0, 0);
            pnlMode.BackColor= Color.FromArgb(180, 0, 0, 0);
            pnlVolume.BackColor = Color.FromArgb(180, 0, 0, 0);
            pnlMusic.BackColor = Color.FromArgb(50, 0, 0, 0);
            pnlAll.BackColor = Color.FromArgb(180, 0, 0, 0);

            dbPanel = new DoubleBufferPanel();
            dbPanel.SetBounds(245, 570, 800, 65);
            dbPanel.BackColor = Color.FromArgb(150, 0, 0, 0);
            this.Controls.Add(dbPanel);
            lblDisplayTime.Location = new Point(440,10);
            lblplaying.Location = new Point(19,12);
            dbPanel.Controls.Add(lblDisplayTime);
            dbPanel.Controls.Add(lblplaying);

            //生成进度条和音量条
            mbp = new myProgressBar(this,20, 40, 510,6);
            dbPanel.Controls.Add(mbp.picFocus);
            dbPanel.Controls.Add(mbp.lblbottom);

            mbpVolume = new myProgressBar(this, 10, 10, 150, 6);
            mbpVolume.updateFocus(150-12);
            pnlVolume.Controls.Add(mbpVolume.picFocus);
            pnlVolume.Controls.Add(mbpVolume.lblbottom);
            mbp.picFocus.MouseDown += new MouseEventHandler(mbp.picFocus_MouseDown);
            mbp.picFocus.MouseMove += new MouseEventHandler(mbp.picFocus_MouseMove);
            mbp.picFocus.MouseUp += new MouseEventHandler(mbp.picFocus_MouseUp);

            mbpVolume.picFocus.MouseDown += new MouseEventHandler(mbpVolume.picFocus_MouseDown);
            mbpVolume.picFocus.MouseMove += new MouseEventHandler(mbpVolume.picFocus_MouseMove);
            mbpVolume.picFocus.MouseUp += new MouseEventHandler(mbpVolume.picFocus_MouseUp);

            //将歌曲目录文件读到客户端列表中显示
            DirectoryInfo dir = new DirectoryInfo("songs");
            FileInfo[] fileInfo = dir.GetFiles();
            List<string> fileNames = new List<string>();
            foreach (FileInfo item in fileInfo)
            {
                fileNames.Add(item.Name);
            }

            mlblsongs = new List<myLabel>();
            for (int i = 0; i < fileNames.Count; i++)
            {
                mlblsongs.Add(new myLabel(fileNames[i].Substring(0, fileNames[i].Length - 4), 0, i * 50, pnlMusic, this));
                mlblsongs[i].setS();
            }

        }

        private void picClose_MouseEnter(object sender, EventArgs e)
        {
            picClose.BackgroundImage = Properties.Resources.close_1;
        }

        private void picClose_MouseLeave(object sender, EventArgs e)
        {
            picClose.BackgroundImage = Properties.Resources.close;
        }

        private void picClose_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void picMins_MouseEnter(object sender, EventArgs e)
        {
            picMins.BackgroundImage = Properties.Resources.mins_1;
        }

        private void picMins_MouseLeave(object sender, EventArgs e)
        {
            picMins.BackgroundImage = Properties.Resources.mins;
        }

        private void picMins_MouseClick(object sender, MouseEventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
        }

        private void picLast_MouseEnter(object sender, EventArgs e)
        {
            picLast.BackColor = Color.FromArgb(30, 255, 255, 255);
        }

        private void picLast_MouseLeave(object sender, EventArgs e)
        {
            picLast.BackColor = Color.Transparent;
        }
        private void picLast_MouseDown(object sender, MouseEventArgs e)
        {
            picLast.BackColor = Color.FromArgb(40, 255, 255, 255);
        }

        private void picLast_MouseUp(object sender, MouseEventArgs e)
        {
            picLast.BackColor = Color.FromArgb(30, 255, 255, 255);
        }

        private void picLast_MouseClick(object sender, MouseEventArgs e)
        {
            if (mlIndex == 0 ||mlIndex==-1)
            {
                mlIndex = pnlMusic.Controls.Count;
            }

            changeInfo(mlblsongs[mlIndex - 1]);

            //加深播放中歌曲颜色
            for (int i = 0; i < mlblsongs.Count; i++)
            {
                if (i == mlIndex - 1)
                {
                    mlblsongs[i].BackColor = Color.FromArgb(100, 0, 0, 0);
                    mlblsongs[i].isClick = true;
                }
                else
                {
                    mlblsongs[i].isClick = false;
                    mlblsongs[i].BackColor = Color.Transparent;
                }
            }
            mlIndex--;
            playCount++;
        }

        private void picNext_MouseEnter(object sender, EventArgs e)
        {
            picNext.BackColor = Color.FromArgb(30, 255, 255, 255);
        }

        private void picNext_MouseUp(object sender, MouseEventArgs e)
        {
            picNext.BackColor = Color.FromArgb(30, 255, 255, 255);
        }

        private void picNext_MouseLeave(object sender, EventArgs e)
        {
            picNext.BackColor = Color.Transparent;
        }
        private void picNext_MouseDown(object sender, MouseEventArgs e)
        {
            picNext.BackColor = Color.FromArgb(40, 255, 255, 255);
        }

        private void picNext_MouseClick(object sender, MouseEventArgs e)
        {
            //picNext.BackgroundImage = Properties.Resources.next;

            if (mlIndex == pnlMusic.Controls.Count - 1)
            {
                mlIndex = -1;
            }

            changeInfo(mlblsongs[mlIndex + 1]);

            //加深播放中歌曲颜色
            for (int i = 0; i < mlblsongs.Count; i++)
            {
                if (i == mlIndex + 1)
                {
                    mlblsongs[i].BackColor = Color.FromArgb(100, 0, 0, 0);
                    mlblsongs[i].isClick = true;
                }
                else
                {
                    mlblsongs[i].isClick = false;
                    mlblsongs[i].BackColor = Color.Transparent;
                }
            }
            mlIndex++;
            playCount++;
        }


        private void picPlay_MouseEnter(object sender, EventArgs e)
        {
            picPlay.BackColor = Color.FromArgb(30, 255, 255, 255);
        }

        private void picPlay_MouseDown(object sender, MouseEventArgs e)
        {
            picPlay.BackColor = Color.FromArgb(40, 255, 255, 255);
        }

        private void picPlay_MouseUp(object sender, MouseEventArgs e)
        {
            picPlay.BackColor = Color.FromArgb(30, 255, 255, 255);
        }

        private void picPlay_MouseLeave(object sender, EventArgs e)
        {
            picPlay.BackColor = Color.Transparent;
        }

        bool isPlay;
        LyricFiles lyricFiles = new LyricFiles();
        int playCount = 0;
        private void picPlay_MouseClick(object sender, MouseEventArgs e)
        {
            if(playCount==0 && pnlMusic.Controls.Count!=0)
            {
                axWindowsMediaPlayer1.URL = "songs\\" + mlblsongs[0]+".mp3";
                changeInfo(mlblsongs[0]);
                mlIndex = 0;
            }
            else if(axWindowsMediaPlayer1.URL!="")
            {
                isPlay = !isPlay;
                if (isPlay)
                {
                    axWindowsMediaPlayer1.Ctlcontrols.play();//播放
                    picPlay.BackgroundImage = Properties.Resources.stop;
                }
                else
                {
                    axWindowsMediaPlayer1.Ctlcontrols.pause();//暂停
                    picPlay.BackgroundImage = Properties.Resources.play;
                }
            }
            playCount++;
        }

        private void picMode_MouseEnter(object sender, EventArgs e)
        {
            picMode.BackColor = Color.FromArgb(30, 255, 255, 255) ;
        }

        private void picMode_MouseLeave(object sender, EventArgs e)
        {
            picMode.BackColor = Color.Transparent;
        }

        private void picMode_MouseClick(object sender, MouseEventArgs e)
        {
            pnlAll.Visible = false;
            pnlVolume.Visible = false;
            if (!pnlMode.Visible)
            {
                pnlMode.Visible = true;
            }
            else
            {
                pnlMode.Visible = false;
            }
        }

        private void picVolume_MouseEnter(object sender, EventArgs e)
        {
            picVolume.BackColor = Color.FromArgb(30, 255, 255, 255);
        }

        private void picVolume_MouseLeave(object sender, EventArgs e)
        {
            picVolume.BackColor = Color.Transparent;
        }

        private void picVolume_MouseClick(object sender, MouseEventArgs e)
        {
            pnlMode.Visible = false;
            pnlAll.Visible = false;
            if (!pnlVolume.Visible)
            {
                pnlVolume.Visible = true;
            }
            else
            {
                pnlVolume.Visible = false;
            }
        }

        private void picLove_MouseEnter(object sender, EventArgs e)
        {
            picLove.BackColor = Color.FromArgb(30, 255, 255, 255);
        }

        private void picLove_MouseLeave(object sender, EventArgs e)
        {
            picLove.BackColor = Color.Transparent;
        }

        private void picLove_MouseClick(object sender, MouseEventArgs e)
        {
            if (axWindowsMediaPlayer1.URL != "")
            {
                string filePath = "love\\like.txt";
                string musicNameLove = mlblsongs[mlIndex].Text;
                string s = File.ReadAllText("love\\like.txt");
                if (s.Contains(musicNameLove))
                {
                    picLove.BackgroundImage = Properties.Resources.like_1;
                    string w = File.ReadAllText(filePath);
                    w = w.Replace(musicNameLove, string.Empty);
                    File.WriteAllText(filePath, w);
                    //去掉文本中的空行
                    File.WriteAllLines("love\\like.txt", from line in File.ReadAllLines("love\\like.txt") where !string.IsNullOrEmpty(line.Trim()) select line);
                }
                else
                {
                    picLove.BackgroundImage = Properties.Resources.like_2;
                    //将喜欢的歌曲进行记录
                    StreamWriter sw = File.AppendText(filePath);
                    sw.WriteLine(musicNameLove);//写你的字符串。
                    sw.Close();
                }
            }
        }
        private void picList_MouseEnter(object sender, EventArgs e)
        {
            picList.BackColor = Color.FromArgb(30, 255, 255, 255);
        }

        private void picList_MouseLeave(object sender, EventArgs e)
        {
            picList.BackColor = Color.Transparent;
        }

        private void picList_MouseClick(object sender, MouseEventArgs e)
        {
            pnlMode.Visible = false;
            pnlVolume.Visible = false;
            //点击奇数次打开，奇数次关闭歌曲列表
            if (!pnlAll.Visible)
            {
                pnlAll.Visible = true;
            }
            else
            {
                pnlAll.Visible = false;
            }


            /* axwindowsmediaplayer1.currentplaylist = axwindowsmediaplayer1.newplaylist("aa", "");
             //遍历打开的集合
             foreach (string fn in filenames)
             {
                 //添加播放列表
                 axwindowsmediaplayer1.currentplaylist.appenditem(axwindowsmediaplayer1.newmedia("songs\\"+fn));
             }*/
        }

        private void picSingle_MouseClick(object sender, MouseEventArgs e)
        {
            isRandom = false;
            axWindowsMediaPlayer1.settings.setMode("loop", true);
            picMode.BackgroundImage = Properties.Resources.single;
            pnlMode.Visible = false;

        }

        private void picSingle_MouseEnter(object sender, EventArgs e)
        {
            picSingle.BackColor = Color.FromArgb(30, 255, 255, 255);
        }

        private void picSingle_MouseLeave(object sender, EventArgs e)
        {
            picSingle.BackColor = Color.Transparent;
        }

        bool isRandom;
        private void picRandom_MouseClick(object sender, MouseEventArgs e)
        {
            axWindowsMediaPlayer1.settings.setMode("loop", false);
            isRandom = true;
            picMode.BackgroundImage = Properties.Resources.random;
            pnlMode.Visible = false;
        }

        private void picRandom_MouseEnter(object sender, EventArgs e)
        {
            picRandom.BackColor = Color.FromArgb(30, 255, 255, 255);
        }

        private void picRandom_MouseLeave(object sender, EventArgs e)
        {
            picRandom.BackColor = Color.Transparent;
        }

        private void picAddmusic_MouseClick(object sender, MouseEventArgs e)
        {
            //添加歌曲到列表并存入指定歌曲目录下
            OpenFileDialog ofd = new OpenFileDialog();
            //ofd.ShowDialog();
            ofd.Filter = "音频(*.mp3)|*.mp3";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //筛选文件类型              
                FileInfo fileInfo = new FileInfo(ofd.FileName);
                if (!File.Exists("songs\\" + fileInfo.Name))
                {
                    File.Copy(ofd.FileName, "songs\\" + fileInfo.Name);

                    int IndexofA = ofd.FileName.LastIndexOf("\\");
                    int IndexofB = ofd.FileName.IndexOf(".");
                    mlblsongs.Add(new myLabel(ofd.FileName.Substring(IndexofA + 1, IndexofB - IndexofA - 1), 0, pnlMusic.Controls.Count * 50, pnlMusic, this));
                    mlblsongs[pnlMusic.Controls.Count].setS();
                }
            }
            else
            {
                return;
            }

        }

        private void picloop_MouseClick(object sender, MouseEventArgs e)
        {
            isRandom = false;
            axWindowsMediaPlayer1.settings.setMode("loop", false);
            picMode.BackgroundImage = Properties.Resources.loop;
            pnlMode.Visible = false;
        }

        private void picloop_MouseEnter(object sender, EventArgs e)
        {
            picloop.BackColor = Color.FromArgb(30, 255, 255, 255);
        }

        private void picloop_MouseLeave(object sender, EventArgs e)
        {
            picloop.BackColor = Color.Transparent;
        }

        //拖动主界面
        Point clickPoint1;
        bool isDrag1;
        private void fraMusicBox_MouseDown(object sender, MouseEventArgs e)
        {
            isDrag1 = true;
            clickPoint1 = new Point(e.X, e.Y);

            pnlAll.Visible = false;
            pnlMode.Visible = false;
            pnlVolume.Visible = false;
        }

        private void fraMusicBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrag1)
            {
                int offsetX = e.X - clickPoint1.X;
                int offsetY = e.Y - clickPoint1.Y;

                this.Location = new Point(this.Location.X + offsetX, this.Location.Y + offsetY);
            }
        }

        private void fraMusicBox_MouseUp(object sender, MouseEventArgs e)
        {
           isDrag1 = false;
        }

        int curLyricLine = 0;
        double pos;
        public double total;
        private void timer1_Tick(object sender, EventArgs e)
        {         
            lblDisplayTime.Text = axWindowsMediaPlayer1.Ctlcontrols.currentPositionString + "/" + axWindowsMediaPlayer1.currentMedia.durationString;
            total = axWindowsMediaPlayer1.currentMedia.duration;       //歌曲总时间  
            pos = axWindowsMediaPlayer1.Ctlcontrols.currentPosition;   //歌曲当前时间

            //若进度条移动，计算 curLyricLine
            for (int i = 0; i < lyricFiles.lstLyric.Count; i++)
            {
                if (pos >= lyricFiles.lstLyric[i].totSecond)
                {
                    curLyricLine = i;
                }
                else if (pos == 0)
                {
                    curLyricLine = 0;
                }
            }

            //同步移动进度条光标
            int value = (int)((pos / total) * (510 - 12));
            mbp.updateFocus(value);

            if (axWindowsMediaPlayer1.status == "已停止" && !axWindowsMediaPlayer1.settings.getMode("loop"))
            {
                if(isRandom)
                {
                    Random rd;
                    int rdNumber;
                    while (true)
                    {
                        //若为随机播放，生成一个随机数,但不出现刚刚结束的歌曲
                        rd= new Random();
                        rdNumber= rd.Next(mlblsongs.Count);
                        if(rdNumber!=mlIndex)
                        {
                            break;
                        }
                    }
                    changeInfo(mlblsongs[rdNumber]);

                    //加深播放中歌曲颜色
                    for (int i = 0; i < mlblsongs.Count; i++)
                    {
                        if (i == rdNumber)
                        {
                            mlblsongs[i].BackColor = Color.FromArgb(100, 0, 0, 0);
                            mlblsongs[i].isClick = true;
                            mlIndex = rdNumber;
                        }
                        else
                        {
                            mlblsongs[i].isClick = false;
                            mlblsongs[i].BackColor = Color.Transparent;
                        }
                    }
                }
                else
                {
                    if (mlIndex == pnlMusic.Controls.Count - 1)
                    {
                        mlIndex = -1;
                    }

                    changeInfo(mlblsongs[mlIndex + 1]);

                    //加深播放中歌曲颜色
                    for (int i = 0; i < mlblsongs.Count; i++)
                    {
                        if (i == mlIndex + 1)
                        {
                            mlblsongs[i].BackColor = Color.FromArgb(100, 0, 0, 0);
                            mlblsongs[i].isClick = true;
                        }
                        else
                        {
                            mlblsongs[i].isClick = false;
                            mlblsongs[i].BackColor = Color.Transparent;
                        }
                    }
                    mlIndex++;
                }               
            }          

            //歌词同步滚动显示
            if (curLyricLine < lyricFiles.lstLyric.Count && lyricFiles.lstLyric.Count > 0)
            {
                    for (int i = 0; i < 12; i++)
                    {
                        if(curLyricLine + i - 5<0 || curLyricLine + i - 5> lyricFiles.lstLyric.Count-1)
                        {
                            lblLyric[i].Text = "";
                        }
                        else
                        {
                            lblLyric[i].Text = lyricFiles.lstLyric[curLyricLine + i - 5].strLyric;
                        }                      
                    }
            }

            //将动态显示的歌词label居中显示
            for (int i = 0; i < 12; i++)
            {
                lblLyric[i].Location = new Point(this.Width / 2 - lblLyric[i].Width / 2, lblLyric[i].Location.Y);
            }

        }
      
        public void changeInfo(myLabel m)
        {

            //更换对应歌曲背景和歌词
            string txName = m.Text;
            lyricFiles.lstLyric.Clear();   //清空原先歌词列表

            //播放选中音乐
            axWindowsMediaPlayer1.URL = "songs\\" + txName + ".mp3";

            timer1.Enabled = true;
            picPlay.BackgroundImage = Properties.Resources.stop;
            isPlay = true;

            //若歌词文件存在
            if (File.Exists("lyrics\\" + txName + ".lrc"))
            {
                lyricFiles.LoadLyricFromFile("lyrics\\" + txName + ".lrc");
            }
            else  //若歌词不存在
            {
                for (int i = 0; i < 12; i++)
                {
                    if (i == 5)
                    {
                        lblLyric[i].Text = "暂未找到歌词!";
                    }
                    else
                    {
                        lblLyric[i].Text = "";
                    }
                }
            }

            //若背景存在
            if (File.Exists("bks\\" + txName + ".jpg"))
            {
                BackgroundImage = Image.FromFile("bks\\" + txName + ".jpg");
            }
            else   //若背景不存在
            {
                BackgroundImage = Properties.Resources.background;
            }

            //若主题存在
            if (File.Exists("thema\\" + txName + ".jpg"))
            {
                picThema.BackgroundImage = Image.FromFile("thema\\" + txName + ".jpg");
            }
            else   //若背景不存在
            {
                picThema.BackgroundImage = Properties.Resources.test;
            }

            //判断正在播放的歌曲之前是否收藏喜欢
            string s = File.ReadAllText("love\\like.txt");
            if(s.Contains(txName))
            {
                picLove.BackgroundImage = Properties.Resources.like_2;
            }
            else
            {
                picLove.BackgroundImage = Properties.Resources.like_1;
            }
            lblplaying.Text = txName;
        }

        private void picList_Click(object sender, EventArgs e)
        {

        }
    }
}
