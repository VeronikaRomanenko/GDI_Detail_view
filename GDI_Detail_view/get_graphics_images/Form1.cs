using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace get_graphics_images
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            try
            {
                Graphics graphics = e.Graphics;
                graphics.DrawImage(Image.FromFile("newImage.jpg"), 0, 0, 300, 200);
                graphics.Dispose();
            }
            catch { }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Image image = Image.FromFile("picture.jpg");
                Graphics graphics = Graphics.FromImage(image);
                Font font = new Font("Verdana", 30, FontStyle.Bold);
                string helloString = "Hello World!";
                //меряем строку методом MeasureString("строка", шрифт)
                SizeF sizef = graphics.MeasureString(helloString, font);
                graphics.DrawString(helloString, font, Brushes.White, 10, 10);
                graphics.DrawRectangle(new Pen(Color.Red, 6), 10, 10, sizef.Width, sizef.Height);
                //сохраняем изображение
                image.Save("newImage.jpg");
                Rectangle clientRectangle = new Rectangle(new Point(0, 0), image.Size);
                image?.Dispose();//if (image != null)
                graphics?.Dispose();
                Invalidate(clientRectangle);
            }
            catch { }
        }
    }
}