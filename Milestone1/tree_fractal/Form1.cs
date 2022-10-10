using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Drawing.Drawing2D;

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
            var angle1 = angle1TextBox.Text;
            var angle2 = angle2TextBox.Text;
            var depth = depthTextBox.Text;
            var length = lengthTextBox.Text;
            var scale = scaleTextBox.Text;
            var bitmap = new Bitmap(curvePictureBox.Size.Width, curvePictureBox.Size.Height);
            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                graphics.SmoothingMode = SmoothingMode.AntiAlias;
                graphics.Clear(curvePictureBox.BackColor);
            }
            curvePictureBox.Image = bitmap;
        }

        private double DegreesToRadians(double degrees)
        {
            var radians = degrees * Math.PI / 180;
            return radians;
        }
    }
}
