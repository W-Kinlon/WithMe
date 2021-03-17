using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QQ2020
{
    class Gometry
    {
        private int boradWidth;
        private Color fillColor;

        public Color FillColor { get => fillColor; set => fillColor = value; }
        public int BoradWidth { get => boradWidth; set => boradWidth = value; }

        public virtual void Draw(Graphics g)
        {

        }
    }

    class ZhiLine : Gometry
    {
        Point startPoint;
        Point endPoint;

        public Point StartPoint { get => startPoint; set => startPoint = value; }
        public Point EndPoint { get => endPoint; set => endPoint = value; }

        public ZhiLine(Color color, int Borad)
        {
            this.FillColor = color;
            this.BoradWidth = Borad;
        }

        public override void Draw(Graphics g)
        {
            if (startPoint != new Point(0, 0) && endPoint != new Point(0, 0))
            {
                g.DrawLine(new Pen(FillColor, BoradWidth), startPoint, endPoint);
            }

        }
    }

    class QuLine : Gometry
    {
        List<Point> points = new List<Point>();

        public List<Point> Points { get => points; set => points = value; }

        public QuLine(Color color, int Borad)
        {
            this.FillColor = color;
            this.BoradWidth = Borad;
        }
        public override void Draw(Graphics g)
        {
            if (points.Count > 1)
                g.DrawLines(new Pen(FillColor, BoradWidth), points.ToArray());
        }
    }

    class Rect : Gometry
    {
        Rectangle rectangle = new Rectangle();


        public Rect(Color color, int Borad)
        {
            this.FillColor = color;
            this.BoradWidth = Borad;
        }

        public Rectangle Rectangle { get => rectangle; set => rectangle = value; }

        public override void Draw(Graphics g)
        {
            g.DrawRectangle(new Pen(FillColor, BoradWidth), Rectangle);
        }
    }

    class Eclp : Gometry
    {
        Rectangle rectangle = new Rectangle();

        public Eclp(Color color, int Borad)
        {
            this.FillColor = color;
            this.BoradWidth = Borad;
        }

        public Rectangle Rectangle { get => rectangle; set => rectangle = value; }

        public override void Draw(Graphics g)
        {
            g.DrawEllipse(new Pen(FillColor, BoradWidth), Rectangle);
        }
    }
}
