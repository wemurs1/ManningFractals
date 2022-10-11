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

namespace tree_fractal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void drawButton_Click(object sender, EventArgs e)
        {
            var angle1 = double.Parse(angle1TextBox.Text);
            var angle2 = double.Parse(angle2TextBox.Text);
            var depth = int.Parse(depthTextBox.Text);
            if (depth < 1) { depth = 1; depthTextBox.Text = depth.ToString(); }
            if (depth > 20) { depth = 20; depthTextBox.Text = depth.ToString(); }
            var length = float.Parse(lengthTextBox.Text);
            var scale = float.Parse(scaleTextBox.Text);
            var bitmap = new Bitmap(curvePictureBox.Size.Width, curvePictureBox.Size.Height);
            var startX = curvePictureBox.Size.Width / 2.0f;
            var startY = curvePictureBox.Size.Height - 20.0f;
            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                graphics.SmoothingMode = SmoothingMode.AntiAlias;
                graphics.Clear(curvePictureBox.BackColor);
                DrawBranch(graphics, depth, scale, angle1, angle2, -90f, length, startX, startY);
            }
            curvePictureBox.Image = bitmap;
        }

        private double DegreesToRadians(double degrees)
        {
            var radians = degrees * Math.PI / 180;
            return (float)radians;
        }

        private void DrawBranch(
            Graphics gr, 
            int depth, 
            float scale,
            double angle1, 
            double angle2, 
            double currentAngle,
            float currentLength, 
            float currentX, 
            float currentY)
        {
            var radians = DegreesToRadians(currentAngle);
            var startX = (int)Math.Round(currentX, 0);
            var startY = (int)Math.Round(currentY, 0);
            var endX = (int)Math.Round(startX + currentLength * Math.Cos(DegreesToRadians(currentAngle)),0);
            var endY = (int)Math.Round(startY + currentLength * Math.Sin(DegreesToRadians(currentAngle)),0);
            var startPoint = new Point(startX, startY);
            var endPoint = new Point(endX, endY);
            gr.DrawLine(Pens.Black, startPoint, endPoint);

            if (--depth > 0)
            {
                DrawBranch(gr, depth, scale, angle1, angle2, currentAngle + angle1, currentLength * scale, endX, endY);
                DrawBranch(gr, depth, scale, angle1, angle2, currentAngle + angle2, currentLength * scale, endX, endY);
            }
        }
    }
}
