﻿namespace tree_fractal
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.angle1TextBox = new System.Windows.Forms.TextBox();
            this.lengthTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.scaleTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.angle2TextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.depthTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.drawButton = new System.Windows.Forms.Button();
            this.curvePictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.curvePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Angle 1:";
            // 
            // angle1TextBox
            // 
            this.angle1TextBox.Location = new System.Drawing.Point(64, 12);
            this.angle1TextBox.Name = "angle1TextBox";
            this.angle1TextBox.Size = new System.Drawing.Size(34, 20);
            this.angle1TextBox.TabIndex = 0;
            this.angle1TextBox.Text = "30";
            this.angle1TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lengthTextBox
            // 
            this.lengthTextBox.Location = new System.Drawing.Point(64, 38);
            this.lengthTextBox.Name = "lengthTextBox";
            this.lengthTextBox.Size = new System.Drawing.Size(34, 20);
            this.lengthTextBox.TabIndex = 3;
            this.lengthTextBox.Text = "60";
            this.lengthTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Length:";
            // 
            // scaleTextBox
            // 
            this.scaleTextBox.Location = new System.Drawing.Point(180, 38);
            this.scaleTextBox.Name = "scaleTextBox";
            this.scaleTextBox.Size = new System.Drawing.Size(34, 20);
            this.scaleTextBox.TabIndex = 4;
            this.scaleTextBox.Text = "0.75";
            this.scaleTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(128, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Scale:";
            // 
            // angle2TextBox
            // 
            this.angle2TextBox.Location = new System.Drawing.Point(180, 12);
            this.angle2TextBox.Name = "angle2TextBox";
            this.angle2TextBox.Size = new System.Drawing.Size(34, 20);
            this.angle2TextBox.TabIndex = 1;
            this.angle2TextBox.Text = "-30";
            this.angle2TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(128, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Angle 2:";
            // 
            // depthTextBox
            // 
            this.depthTextBox.Location = new System.Drawing.Point(296, 12);
            this.depthTextBox.Name = "depthTextBox";
            this.depthTextBox.Size = new System.Drawing.Size(34, 20);
            this.depthTextBox.TabIndex = 2;
            this.depthTextBox.Text = "9";
            this.depthTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(244, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Depth:";
            // 
            // drawButton
            // 
            this.drawButton.Location = new System.Drawing.Point(139, 64);
            this.drawButton.Name = "drawButton";
            this.drawButton.Size = new System.Drawing.Size(75, 23);
            this.drawButton.TabIndex = 5;
            this.drawButton.Text = "Draw";
            this.drawButton.UseVisualStyleBackColor = true;
            this.drawButton.Click += new System.EventHandler(this.drawButton_Click);
            // 
            // curvePictureBox
            // 
            this.curvePictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.curvePictureBox.BackColor = System.Drawing.Color.White;
            this.curvePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.curvePictureBox.Location = new System.Drawing.Point(15, 93);
            this.curvePictureBox.Name = "curvePictureBox";
            this.curvePictureBox.Size = new System.Drawing.Size(326, 255);
            this.curvePictureBox.TabIndex = 11;
            this.curvePictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.AcceptButton = this.drawButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 360);
            this.Controls.Add(this.curvePictureBox);
            this.Controls.Add(this.drawButton);
            this.Controls.Add(this.depthTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.scaleTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.angle2TextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lengthTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.angle1TextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "tree_fractal";
            ((System.ComponentModel.ISupportInitialize)(this.curvePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox angle1TextBox;
        private System.Windows.Forms.TextBox lengthTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox scaleTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox angle2TextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox depthTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button drawButton;
        private System.Windows.Forms.PictureBox curvePictureBox;
    }
}

