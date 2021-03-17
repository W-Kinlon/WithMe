using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QQ2020
{
    public partial class FrmCutScreen : Form
    {
        private bool isDrawing;          //是否开始绘制
        private bool rectReady;          //矩形是否绘制完成
        private Image baseImage;         //基本图形(原来的画面)
        private Image backImage;         //背景图形(降低透明度的画面)
        private Image cutImage;          //画了矩形和不透明部分原图的新图
        private Rectangle rect;          //截图的矩形图像区域
        private Point downPoint;         //鼠标按下的点
        private Color pointColor;        //鼠标当前点的颜色
        private FrmChat frmChat;         //向父窗体传值时用

        public FrmCutScreen(Image bgImage)
        {
            InitializeComponent();
            baseImage = bgImage;
        }
        private void FrmScreenBody_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            isDrawing = false;
            rect = new Rectangle();
            rectReady = false;
            backImage = ToTransparent(baseImage, 0.6F);//克隆保存 降低透明度的背景图片
            this.BackgroundImage = backImage;
            frmChat = (FrmChat)this.Owner;
        }

        private void FrmScreenBody_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDrawing = true;//左键按下，开始绘制矩形区域
                if (rectReady == false)
                {
                    rect.X = e.X;
                    rect.Y = e.Y;
                    downPoint = new Point(e.X, e.Y);
                    //显示图像放大镜控件
                    pnlCutMag_glass.Location = new Point(e.X + 10, e.Y + 10);
                    pnlCutMag_glass.Visible = true;
                    //显示原图像的鼠标处像素点的rgb值
                    Bitmap bmp = new Bitmap(baseImage);
                    pointColor = bmp.GetPixel(e.X, e.Y);
                    string strRGB = "(rgb)"
                        + pointColor.R.ToString()
                        + ","
                        + pointColor.G.ToString()
                        + ","
                        + pointColor.B.ToString();
                    labRGB.Text = strRGB;
                }
            }
        }

        private void FrmScreenBody_MouseMove(object sender, MouseEventArgs e)
        {
            if (rectReady == false && isDrawing == true)
            {
                //定位矩形区域
                int width = System.Math.Abs(downPoint.X - e.X);
                int heigth = System.Math.Abs(downPoint.Y - e.Y);
                rect.X = System.Math.Min(downPoint.X, e.X);
                rect.Y = System.Math.Min(downPoint.Y, e.Y);
                rect.Width = width;
                rect.Height = heigth;
                //在克隆的图像上画矩形，并成为窗体背景
                cutImage = DrawCutImage((Image)backImage.Clone());
                //Graphics.DrawImage(DrawScreen(), 0, 0);//会由于多次重叠而变得不透明
                this.BackgroundImage = cutImage;
                //快速移动鼠标时会重叠放大镜控件，也许多线程能解决
                magnifyingGlass(cutImage, rect, e.X, e.Y);//刷新图像放大镜控件
            }
        }

        private void FrmScreenBody_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                //左键松开，停止绘制，矩形区域完成
                isDrawing = false;
                rectReady = true;
                //保存
                Image memory = new Bitmap(rect.Width, rect.Height);
                Graphics g = Graphics.FromImage(memory);
                //将cutImage的rect区域保存到Image memory中
                g.CopyFromScreen(rect.X, rect.Y, 0, 0, rect.Size);
                frmChat.addImageTOrtbChat(memory);//memory放到聊天窗口的聊天框中
                pnlCutMag_glass.Visible = false;
                this.Close();
            }
        }

        private Image DrawCutImage(Image cutImage)
        {
            Graphics Painter = Graphics.FromImage(cutImage);
            Pen pen = new Pen(Brushes.Blue, 1);
            //在image(降低透明度的图像)上画矩形框
            Painter.DrawRectangle(pen, rect.X - 1, rect.Y - 1, rect.Width + 2, rect.Height + 2);
            //在cutImage的rect区域内填充baseimage（原图像）对应区域的部分
            Painter.DrawImage(baseImage, rect, rect.X, rect.Y, rect.Width, rect.Height, GraphicsUnit.Pixel);
            return cutImage;
        }

        /// <summary>
        /// 图像明暗(透明度)调整
        /// </summary>
        /// <param name="image">原始图</param>
        /// <param name="opacity">透明度[0, 1]</param>
        /// <returns></returns>
        public Image ToTransparent(Image image, float opacity)
        {
            if (opacity >= 1 || opacity < 0) return image;
            Bitmap bitmap = new Bitmap(image.Width, image.Height);
            using (var g = Graphics.FromImage(bitmap))
            {
                var matrix = new ColorMatrix { Matrix33 = opacity };
                var attributes = new ImageAttributes();
                attributes.SetColorMatrix(matrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
                var rectangle = new Rectangle(0, 0, bitmap.Width, bitmap.Height);
                g.DrawImage(image, rectangle, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, attributes);
            }
            return bitmap;
        }
        
        /// <summary>
        /// 显示鼠标处像素点的rgb值，以及截图矩形大小
        /// </summary>
        /// <param name="image">原始图</param>
        /// <param name="opacity">透明度[0, 1]</param>
        /// <returns></returns>
        public void magnifyingGlass(Image cutMmage, Rectangle rect, int locationX, int locationY)
        {
            if (cutImage != null)
            {
                //截取cutMmage（绘制了矩形框的背景图）的鼠标附近区域，放入picMagImage控件
                Bitmap bmp1 = new Bitmap(20, 15);//picMagImage控件大小的十分之一
                Graphics graphic = Graphics.FromImage(bmp1);
                graphic.DrawImage(cutMmage,
                    0, 0,
                    new Rectangle(locationX - 10, locationY - 7, bmp1.Width, bmp1.Height),
                    GraphicsUnit.Pixel);
                picMagImage.Image = bmp1;
            }
            //位置的代码可以优化，鼠标在角落时让放大镜窗体也可见
            pnlCutMag_glass.Location = new Point(locationX + 10, locationY + 10);
            
            //显示截图矩形框大小
            string strSize = "(size)" + rect.Width.ToString() + "," + rect.Height.ToString();
            labSize.Text = strSize;
            //显示原图像的鼠标处像素点的rgb值
            Bitmap bmp2 = new Bitmap(baseImage);
            pointColor = bmp2.GetPixel(locationX, locationY);
            string strRGB = "(rgb)"
                + pointColor.R.ToString()
                + ","
                + pointColor.G.ToString()
                + ","
                + pointColor.B.ToString();
            labRGB.Text = strRGB;
        }

        private void FrmCutScreen_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.C)
            {
                //rgb值放到剪贴板中
                Clipboard.SetText(
                    pointColor.R.ToString() + "," + pointColor.G.ToString() + "," + pointColor.B.ToString());
            }
        }
    }
}
