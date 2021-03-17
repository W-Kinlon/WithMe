using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyMusicBox
{
    public class myProgressBar
    {
        public PictureBox picFocus;
        public Label lbltop;
        public Label lblbottom;
        int value = 0;
        int x1;
        int y1;
        int h1;
        int w1;
        fraMusicBox f1;

        public myProgressBar(fraMusicBox f, int x, int y, int w, int h)
        {
            //绘制进度条，用两个label以及一个picturebox组合为进度条
            lblbottom = new Label();
            lbltop = new Label();
            lblbottom.BackColor = Color.Gray;
            lbltop.BackColor = Color.Yellow;

            //进度条上的光标
            picFocus = new PictureBox();
            picFocus.Size = new Size(12, 12);
            picFocus.Location = new Point(x + value, y - (6 - h / 2));
            picFocus.BackgroundImage = Properties.Resources.yellowyuan;
            picFocus.BackgroundImageLayout = ImageLayout.Stretch;
            picFocus.BackColor = Color.Transparent;
            picFocus.BringToFront();//将控件放置所有控件最顶层 

            lblbottom.SetBounds(x, y, w, h);
            lbltop.Size = new Size(value, h);
            lblbottom.Controls.Add(lbltop);
            f.Controls.Add(picFocus);
            f.Controls.Add(lblbottom);

            x1 = x;
            y1 = y;
            h1 = h;
            w1 = w;
            f1 = f;

        }
        public void updateFocus(int value)
        {
            picFocus.Location = new Point(x1 + value, y1 - (6 - h1 / 2));
            lbltop.Size = new Size(value, h1);
        }

        Point clickPoint2;
        public bool isDrag2;
        internal void picFocus_MouseDown(object sender, MouseEventArgs e)
        {
            if(f1.axWindowsMediaPlayer1.URL != "")
            {
                isDrag2 = true;
                clickPoint2 = new Point(e.X, e.Y);
            }
        }

        int offsetX;
        int offsetY;
        double posNew;
        internal void picFocus_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrag2)
            {
                offsetX = e.X - clickPoint2.X;
                offsetY = e.Y - clickPoint2.Y;

                if (picFocus.Location.X >= lblbottom.Location.X && picFocus.Location.X <= lblbottom.Location.X + w1 - 12)
                {
                    picFocus.Location = new Point(picFocus.Location.X + offsetX, picFocus.Location.Y);
                }

                if (picFocus.Location.X < lblbottom.Location.X)
                {
                    picFocus.Location = new Point(lblbottom.Location.X, picFocus.Location.Y);
                }

                if (picFocus.Location.X > lblbottom.Location.X + w1 - 12)
                {
                    picFocus.Location = new Point(lblbottom.Location.X + w1 - 12, picFocus.Location.Y);
                }

                if (w1 == 510)
                {
                    if(f1.axWindowsMediaPlayer1.URL!="")
                    {
                        //计算歌曲应该播放的时间点
                        posNew = (double)(picFocus.Location.X - lblbottom.Location.X) / (double)(510 - 12) * f1.total;
                        //同步移动进度条光标
                        int value = (int)((posNew / f1.axWindowsMediaPlayer1.currentMedia.duration) * (510 - 12));
                        f1.mbp.updateFocus(value);
                    }
                }
                else if (w1 == 150)
                {
                    int value = picFocus.Location.X - lblbottom.Location.X;
                    this.updateFocus(value);
                    f1.axWindowsMediaPlayer1.settings.volume = (int)(((double)(lbltop.Width) / (double)lblbottom.Width) * 100);
                }
            }
        }

        internal void picFocus_MouseUp(object sender, MouseEventArgs e)
        {
            isDrag2 = false;
            if (w1 == 510)
            {
                f1.axWindowsMediaPlayer1.Ctlcontrols.currentPosition = posNew;
            }
        }
    }
}
