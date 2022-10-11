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

namespace koch_fractal
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
            if (depth > 8) { depth = 8; depthTextBox.Text = depth.ToString(); }
            var bitmap = new Bitmap(curvePictureBox.Size.Width, curvePictureBox.Size.Height);
            var startX = 10.0f;
            var startY = curvePictureBox.Size.Height * 2.0f / 3.0f;
            float length = curvePictureBox.Size.Width - 20.0f;
            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                graphics.SmoothingMode = SmoothingMode.AntiAlias;
                graphics.Clear(curvePictureBox.BackColor);
                DrawKochCurve(graphics, depth, 0f, length, ref startX, ref startY);
            }
            curvePictureBox.Image = bitmap;
        }

        private double DegreesToRadians(double degrees)
        {
            var radians = degrees * Math.PI / 180;
            return (float)radians;
        }

        private void DrawKochCurve(Graphics gr, int depth, double angle, float length, ref float x, ref float y)
        {
            var radians = DegreesToRadians(angle);
            var startX = (int)Math.Round(x, 0);
            var startY = (int)Math.Round(y, 0);
            var endX = (int)Math.Round(x + length * Math.Cos(radians), 0);
            var endY = (int)Math.Round(y + length * Math.Sin(radians), 0);
            var startPoint = new Point(startX, startY);
            var endPoint = new Point(endX, endY);

            if (depth-- > 0)
            {
                var thirdLength = length / 3;
                var firstThirdX = (float)Math.Round(x + thirdLength * Math.Cos(radians), 0);
                var firstThirdY = (float)Math.Round(y + thirdLength * Math.Sin(radians), 0);
                var secondThirdX = (float)Math.Round(x + (thirdLength * 2) * Math.Cos(radians), 0);
                var secondThirdY = (float)Math.Round(y + (thirdLength * 2) * Math.Sin(radians), 0);
                var peakRadians = DegreesToRadians(angle - 60);
                var peakX = (float)Math.Round(firstThirdX + thirdLength * Math.Cos(peakRadians), 0);
                var peakY = (float)Math.Round(firstThirdY + thirdLength * Math.Sin(peakRadians), 0);
                DrawKochCurve(gr, depth, angle, thirdLength, ref  x, ref  y); // first line
                DrawKochCurve(gr, depth, angle - 60, thirdLength, ref firstThirdX, ref firstThirdY);
                DrawKochCurve(gr, depth, angle + 60, thirdLength, ref peakX, ref peakY);
                DrawKochCurve(gr, depth, angle, thirdLength, ref secondThirdX, ref secondThirdY);
            }
            else
            {
                gr.DrawLine(Pens.Black, startPoint, endPoint);
            }
        }
    }
}
