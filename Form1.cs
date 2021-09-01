using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniPaint
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] figures = new string[] { "Circle", "Rectangle", "Triangle", };
            cbx_Figures.Items.AddRange(figures);
            cbx_Figures.SelectedIndex = 0;
            rbtn_Outline.Checked = true;
        }

        public interface IFigure
        {
            Point Point { get; set; }
            Size Size { get; set; }
            Color Color { get; set; }
        }

        class Circle : IFigure
        {
            public Point Point { get; set; }
            public Size Size { get; set; }
            public Color Color { get; set; }
        }

        class Rectangle : IFigure
        {
            public Point Point { get; set; }
            public Size Size { get; set; }
            public Color Color { get; set; }
        }

        class Triangle : IFigure
        {
            public Point Point { get; set; }
            public Size Size { get; set; }
            public Color Color { get; set; }
        }

        public interface IFactory
        {
            IFigure GetFigure();
        }

        public class CircleFactory : IFactory
        {
            public IFigure GetFigure() => new Circle();
        }

        public class RectangleFactory : IFactory
        {
            public IFigure GetFigure() => new Rectangle();
        }

        public class TriangleFactory : IFactory
        {
            public IFigure GetFigure() => new Triangle();
        }


        private void cbx_Figures_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbx_Figures.SelectedItem.ToString() == "Circle")
            {
                FigureFactory = new CircleFactory();
            }
            else if (cbx_Figures.SelectedItem.ToString() == "Rectangle")
            {
                FigureFactory = new RectangleFactory();
            }
            else if (cbx_Figures.SelectedItem.ToString() == "Triangle")
            {
                FigureFactory = new TriangleFactory();
            }
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            IFigure figure = FigureFactory.GetFigure();
            if (figure is Circle)
            {
                Circle circle = new Circle();
                circle.Color = FigureColor;
                circle.Size = new Size(int.Parse(tbx_Width.Text), int.Parse(tbx_Height.Text));
                circle.Point = e.Location;
                Figures.Add(circle);
            }
            else if (figure is Rectangle rect)
            {
                rect.Color = FigureColor;
                rect.Size = new Size(int.Parse(tbx_Width.Text), int.Parse(tbx_Height.Text));
                rect.Point = e.Location;
                Figures.Add(rect);
            }
            else if (figure is Triangle trian)
            {
                trian.Color = FigureColor;
                trian.Size = new Size(int.Parse(tbx_Width.Text), int.Parse(tbx_Height.Text));
                trian.Point = e.Location;
                Figures.Add(trian);
            }

            this.Refresh();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(FigureColor, 5);
            SolidBrush brush = new SolidBrush(FigureColor);

            using (var g = e.Graphics)
            {
                foreach (var item in Figures)
                {
                    if (item is Circle circle)
                    {
                        if (rbtn_Fill.Checked)
                        {
                            g.FillEllipse(new SolidBrush(circle.Color), circle.Point.X, circle.Point.Y, circle.Size.Width, circle.Size.Height);
                        }
                        else
                        {
                            g.DrawEllipse(new Pen(circle.Color, 5), circle.Point.X, circle.Point.Y, circle.Size.Width, circle.Size.Height);
                        }
                    }
                    else if (item is Rectangle rect)
                    {
                        if (rbtn_Fill.Checked)
                        {
                            g.FillRectangle(brush, rect.Point.X, rect.Point.Y, rect.Size.Width, rect.Size.Height);
                        }
                        else
                        {
                            g.DrawRectangle(pen, rect.Point.X, rect.Point.Y, rect.Size.Width, rect.Size.Height);
                        }
                    }
                    else if (item is Triangle trian)
                    {
                        Point[] points = new Point[]
                        {
                            new Point(400, 200),
                            //new Point(430, 230),
                            //new Point(390, 250),
                            //new Point(300, 220),
                            //new Point(400, 200)
                        };

                        if (rbtn_Fill.Checked)
                        {
                            g.FillPolygon(brush, points);
                        }
                        else
                        {
                            g.DrawPolygon(pen, points);
                        }
                    }
                }
            }
        }

        public List<IFigure> Figures { get; set; } = new List<IFigure>();
        public Color FigureColor { get; set; } = Color.Black;
        public IFactory FigureFactory { get; set; }
    }
}
