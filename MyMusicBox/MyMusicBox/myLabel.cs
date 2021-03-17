using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyMusicBox
{
    //自定义歌曲列表中存放每首歌曲的控件
    public class myLabel : Label
    {
        string s;
        int x;
        int y;
        Panel p;
        fraMusicBox f;
        public bool isClick;

        public myLabel(string s, int x, int y, Panel p, fraMusicBox f)
        {
            myLabel m = this;
            this.s = s;
            this.x = x;
            this.y = y;
            this.p = p;
            this.f = f;
            m.MouseEnter += new EventHandler(m_MouseEnter);
            m.MouseLeave += new EventHandler(m_MouseLeave);
            m.MouseDoubleClick += new MouseEventHandler(m_MouseDoubleClick);
        }

        private void m_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            //加深选中歌曲颜色
            for (int i = 0; i < f.mlblsongs.Count; i++)
            {
                if (this.Text == f.mlblsongs[i].Text)
                {
                    f.mlblsongs[i].BackColor = Color.FromArgb(100, 0, 0, 0);
                    isClick = true;
                    f.mlIndex = i;
                }
                else
                {
                    f.mlblsongs[i].isClick = false;
                    f.mlblsongs[i].BackColor = Color.Transparent;
                }
            }


            f.changeInfo(this);
        }

        private void m_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(100, 0, 0, 0);
        }
        private void m_MouseLeave(object sender, EventArgs e)
        {
            if (!this.isClick)
            {
                this.BackColor = Color.Transparent;
            }

        }

        public void setS()
        {
            this.Text = s;
            this.AutoSize = false;
            this.Size = new Size(p.Width - 1, 50);
            this.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;   //文在在label上垂直居中左对齐
            this.BackColor = Color.Transparent;
            this.Font = new Font("幼圆", 14);
            this.ForeColor = Color.White;
            this.Location = new Point(x, y);
            p.Controls.Add(this);
        }
    }
}
