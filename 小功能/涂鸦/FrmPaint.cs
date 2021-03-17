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
    public partial class FormTuYa : Form
    {
        public FormTuYa()
        {
            InitializeComponent();
        }
        bool isDrawing;
        bool isZhi, isQu, isRect, isEclp;
        ZhiLine zhiLine;
        QuLine quLine;
        Rect rect;
        Eclp eclp;
        int startX;
        int startY;
        Rectangle rectangle;
        List<Gometry> gometries = new List<Gometry>();

        Color color = Color.Black;
        int boradWidth = 3;

        private void FormTuYa_Load(object sender, EventArgs e)
        {
            isZhi = true;
            Change();

            currentColor.Text = "当前颜色：Black";
            currentBorad.Text = "当前笔尖：3";
        }
        private void FormTuYa_MouseDown(object sender, MouseEventArgs e)
        {
            isDrawing = true;
            if (isZhi)
                zhiLine = new ZhiLine(color, boradWidth)
                {
                    StartPoint = e.Location
                };
            if (isQu)
            {
                quLine = new QuLine(color, boradWidth);
                quLine.Points.Add(e.Location);
            }
            if (isRect)
            {
                rect = new Rect(color, boradWidth);
                startX = e.X;
                startY = e.Y;
                rectangle = new Rectangle(e.X, e.Y, 0, 0);
            }
            if (isEclp)
            {
                eclp = new Eclp(color, boradWidth);
                startX = e.X;
                startY = e.Y;
                rectangle = new Rectangle(e.X, e.Y, 0, 0);
            }
        }

        private void FormTuYa_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                if (isZhi)
                    zhiLine.EndPoint = e.Location;
                if (isQu)
                    quLine.Points.Add(e.Location);
                if (isRect || isEclp)
                {
                    if (e.X > startX && e.Y < startY)
                    {
                        rectangle.Width = e.X - startX;
                        rectangle.Height = startY - e.Y;
                        rectangle.Y = e.Y;
                    }
                    if (e.X > startX && e.Y > startY)
                    {
                        rectangle.Width = e.X - startX;
                        rectangle.Height = -startY + e.Y;
                    }
                    if (e.X < startX && e.Y < startY)
                    {
                        rectangle.Width = -e.X + startX;
                        rectangle.Height = startY - e.Y;
                        rectangle.Location = e.Location;
                    }
                    if (e.X < startX && e.Y > rectangle.Y)
                    {
                        rectangle.Width = -e.X + startX;
                        rectangle.Height = -startY + e.Y;
                        rectangle.X = e.X;
                    }
                    if (isRect)
                        rect.Rectangle = rectangle;
                    if (isEclp)
                        eclp.Rectangle = rectangle;
                }
            }

            this.Invalidate();
        }

        private void FormTuYa_MouseUp(object sender, MouseEventArgs e)
        {
            isDrawing = false;
            if (isZhi)
                gometries.Add(zhiLine);
            if (isQu)
                gometries.Add(quLine);
            if (isRect)
                gometries.Add(rect);
            if (isEclp)
                gometries.Add(eclp);



            this.Invalidate();
        }

        private void FormTuYa_Paint(object sender, PaintEventArgs e)
        {
            if (isDrawing)
            {
                if (isZhi)
                    zhiLine.Draw(e.Graphics);
                if (isQu)
                    quLine.Draw(e.Graphics);
                if (isRect)
                    rect.Draw(e.Graphics);
                if (isEclp)
                    eclp.Draw(e.Graphics);
            }
            if (gometries.Count > 0)
            {
                for (int i = 0; i < gometries.Count; i++)
                {
                    gometries[i].Draw(e.Graphics);
                }
            }
        }

        //选择粗细
        private void borad1_Click(object sender, EventArgs e)
        {
            boradWidth = 3;
            currentBorad.Text = "当前笔尖：3";
        }
        private void borad2_Click(object sender, EventArgs e)
        {
            boradWidth = 5;
            currentBorad.Text = "当前笔尖：5";
        }
        private void borad3_Click(object sender, EventArgs e)
        {
            boradWidth = 8;
            currentBorad.Text = "当前笔尖：8";
        }
        private void borad4_Click(object sender, EventArgs e)
        {
            boradWidth = 12;
            currentBorad.Text = "当前笔尖：12";
        }

        private void panelTitle_Paint(object sender, PaintEventArgs e)
        {

        }

        //选择图形
        private void ZhiLine_Click(object sender, EventArgs e)
        {
            isZhi = true;
            isEclp = isRect = isQu = false;
            Change();

        }
        private void Qu_Click(object sender, EventArgs e)
        {
            isQu = true;
            isEclp = isRect = isZhi = false;
            Change();
        }
        private void Rectangle_Click(object sender, EventArgs e)
        {
            isRect = true;
            isQu = isEclp = isZhi = false;
            Change();
        }

        private void Eclipse_Click(object sender, EventArgs e)
        {
            isEclp = true;
            isQu = isRect = isZhi = false;
            Change();
        }

        //改变图形灰度
        private void Change()
        {
            if (isZhi)
            {
                Zhi.BackgroundImage = Image.FromFile(@"../../img/直线2.png");
                Qu.BackgroundImage = Image.FromFile(@"../../img/曲线.png");
                DrawRect.BackgroundImage = Image.FromFile(@"../../img/矩形.png");
                Eclipse.BackgroundImage = Image.FromFile(@"../../img/椭圆.png");
            }
            if (isQu)
            {
                Zhi.BackgroundImage = Image.FromFile(@"../../img/直线.png");
                Qu.BackgroundImage = Image.FromFile(@"../../img/曲线2.png");
                DrawRect.BackgroundImage = Image.FromFile(@"../../img/矩形.png");
                Eclipse.BackgroundImage = Image.FromFile(@"../../img/椭圆.png");
            }
            if (isRect)
            {
                Zhi.BackgroundImage = Image.FromFile(@"../../img/直线.png");
                Qu.BackgroundImage = Image.FromFile(@"../../img/曲线.png");
                DrawRect.BackgroundImage = Image.FromFile(@"../../img/矩形2.png");
                Eclipse.BackgroundImage = Image.FromFile(@"../../img/椭圆.png");
            }
            if (isEclp)
            {
                Zhi.BackgroundImage = Image.FromFile(@"../../img/直线.png");
                Qu.BackgroundImage = Image.FromFile(@"../../img/曲线.png");
                DrawRect.BackgroundImage = Image.FromFile(@"../../img/矩形.png");
                Eclipse.BackgroundImage = Image.FromFile(@"../../img/椭圆2.png");
            }

            ReDraw.BackgroundImage = Image.FromFile(@"../../img/撤销.png");
        }


        //选择颜色
        private void Black_Click(object sender, EventArgs e)
        {
            color = Color.Black;
            currentColor.Text = "当前颜色：Black";
        }

        private void Tomato_Click(object sender, EventArgs e)
        {
            color = Color.Tomato;
            currentColor.Text = "当前颜色：Tomato";
        }

        private void Yello_Click(object sender, EventArgs e)
        {
            color = Color.Yellow;
            currentColor.Text = "当前颜色：Yellow";
        }

        private void Green_Click(object sender, EventArgs e)
        {
            color = Color.Green;
            currentColor.Text = "当前颜色：Green";
        }

        private void Blue_Click(object sender, EventArgs e)
        {
            color = Color.Blue;
            currentColor.Text = "当前颜色：Blue";
        }

        private void Puple_Click(object sender, EventArgs e)
        {
            color = Color.Purple;
            currentColor.Text = "当前颜色：Purple";
        }

        private void Red_Click(object sender, EventArgs e)
        {
            color = Color.Red;
            currentColor.Text = "当前颜色：Red";
        }




        private void ReDraw_Click(object sender, EventArgs e)
        {
            if (gometries.Count > 0)
            {
                gometries.RemoveAt(gometries.Count - 1);
                this.Invalidate();
            }
            else
            {
                MessageBox.Show("没有可撤销的涂鸦");
            }
        }
    }
}
