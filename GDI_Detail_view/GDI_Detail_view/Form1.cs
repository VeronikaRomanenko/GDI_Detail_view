using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GDI_Detail_view
{
    public partial class Form1 : Form
    {
        //Способы получения доступа к обьекту класса Graphics
        public Form1()
        {
            InitializeComponent();
            //Paint += Form1_Paint;
        }

        //1-ый способ получения контекста устройства
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Font font = new Font("Arial", 30, FontStyle.Bold);
            graphics.DrawString("Понедельник - день хороший", font, Brushes.Green, 10, 10);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Font font = new Font("Arial", 30, FontStyle.Bold);
            //2-ой способ получения контекста используя переопределение метода OnPaint(e)
            //Graphics graphics = e.Graphics;
            //3-ий способ получения контекста устройства
            Graphics graphics = CreateGraphics();
            graphics.DrawString("Понедельник - день хороший", font, Brushes.Green, 10, 10);
        }
    }
}