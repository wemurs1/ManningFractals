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
using System.Net;

namespace hilbert_fractal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void drawButton_Click(object sender, EventArgs e)
        {
            int depth = int.Parse(depthTextBox.Text);
            if (depth < 1) depth = 1;
            else if (depth > 8) depth = 8;
            int width = curvePictureBox.ClientSize.Width;
            int height = curvePictureBox.ClientSize.Height;
            int size = Math.Min(width, height) - 20;

            // The initial drawing position.
            float x = (width - size) / 2f;
            float y = (height - size) / 2f;

            // Compute the side length for this depth.
            float startLength = (float)(size / (Math.Pow(2, depth) - 1));
            var bitmap = new Bitmap(curvePictureBox.Size.Width, curvePictureBox.Size.Height);
            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                graphics.SmoothingMode = SmoothingMode.AntiAlias;
                graphics.Clear(curvePictureBox.BackColor);
                DrawHilbertCurve(graphics, depth, startLength, 0, ref x, ref y);
            }
            curvePictureBox.Image = bitmap;
        }

        private double DegreesToRadians(double degrees)
        {
            var radians = degrees * Math.PI / 180;
            return (float)radians;
        }

        private void DrawHilbertCurve(Graphics gr, int depth, float dx, float dy, ref float x, ref float y)
        {
            if (depth > 1) DrawHilbertCurve(gr, depth - 1, dy, dx, ref x, ref y);
            DrawRelative(gr, dx, dy, ref x, ref y);
            if (depth > 1) DrawHilbertCurve(gr, depth - 1, dx, dy, ref x, ref y);
            DrawRelative(gr, dy, dx, ref x, ref y);
            if (depth > 1) DrawHilbertCurve(gr, depth - 1, dx, dy, ref x, ref y);
            DrawRelative(gr, -dx, -dy, ref x, ref y);
            if (depth > 1) DrawHilbertCurve(gr, depth - 1, -dy, -dx, ref x, ref y);
        }

        private void DrawRelative(Graphics gr, float dx, float dy, ref float x, ref float y)
        {
            var startPoint = new Point((int)Math.Round(x, 0), (int)Math.Round(y, 0));
            var endPoint = new Point((int)Math.Round(x + dx,0), (int)Math.Round(y + dy,0));
            gr.DrawLine(Pens.Black, startPoint, endPoint);
            x = endPoint.X;
            y = endPoint.Y;
        }
    }
}
