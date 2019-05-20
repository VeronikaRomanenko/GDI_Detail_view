using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simple_paint_figure
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Paint += Form1_Paint;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            //Line - линия
            g.DrawLine(new Pen(Brushes.Red, 6), new Point(10, 10), new Point(100, 100));
            //Rectangle - прямоугольник
            g.DrawRectangle(new Pen(Brushes.Coral, 5), new Rectangle(120, 10, 200, 100));
            //Pie - пирог
            g.DrawPie(new Pen(Brushes.Crimson, 5), 350, 10, 150, 150, 90, 270);
            //Текст
            g.DrawString("Hello Bingo", new Font("Arial", 30), Brushes.Black, 10, 150);
            //Элипс
            g.DrawEllipse(new Pen(Brushes.Crimson, 5), 100, 230, 30, 30);
        }
    }
}