using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Drawing.Drawing2D;
using System.Reflection.Metadata;

namespace sierpinski_fractals
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void drawButton_Click(object sender, EventArgs e)
        {
            var depth = int.Parse(depthTextBox.Text);
            if (depth < 0) { depth = 0; depthTextBox.Text = depth.ToString(); }
            if (depth > 6) { depth = 8; depthTextBox.Text = depth.ToString(); }
            const int margin = 10;
            int width = curvePictureBox.ClientSize.Width;
            int height = curvePictureBox.ClientSize.Height;
            float triangleHeight = height - 2 * margin;
            float triangleWidth = (float)(triangleHeight * 2 / Math.Sqrt(3));
            PointF p1 = new PointF(width / 2f, margin);
            PointF p2 = new PointF(width / 2f - triangleWidth / 2f, margin + triangleHeight);
            PointF p3 = new PointF(width / 2f + triangleWidth / 2f, margin + triangleHeight);
            var bitmap = new Bitmap(curvePictureBox.Size.Width, curvePictureBox.Size.Height);
            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                graphics.SmoothingMode = SmoothingMode.AntiAlias;
                graphics.Clear(curvePictureBox.BackColor);
                DrawSierpinskiTriangle(graphics, depth, p1, p2, p3);
            }
            curvePictureBox.Image = bitmap;
        }

        private double DegreesToRadians(double degrees)
        {
            var radians = degrees * Math.PI / 180;
            return (float)radians;
        }

        private void DrawSierpinskiTriangle(Graphics gr, int depth, PointF p1, PointF p2, PointF p3)
        {
            if (depth == 0)
            {
                PointF[] points = { p1, p2, p3 };
                gr.FillPolygon(Brushes.Red, points);
            }
            else
            {
                PointF p12 = new PointF((p1.X + p2.X) / 2f, (p1.Y + p2.Y) / 2f);
                PointF p23 = new PointF((p2.X + p3.X) / 2f, (p2.Y + p3.Y) / 2f);
                PointF p31 = new PointF((p3.X + p1.X) / 2f, (p3.Y + p1.Y) / 2f);
                depth--;
                DrawSierpinskiTriangle(gr, depth, p1, p12, p31);
                DrawSierpinskiTriangle(gr, depth, p12, p2, p23);
                DrawSierpinskiTriangle(gr, depth, p31, p23, p3);
            }
        }
    }
}
