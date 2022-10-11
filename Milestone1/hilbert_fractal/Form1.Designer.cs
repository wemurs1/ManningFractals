namespace hilbert_fractal
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
            this.depthTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.drawButton = new System.Windows.Forms.Button();
            this.curvePictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.curvePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // depthTextBox
            // 
            this.depthTextBox.Location = new System.Drawing.Point(72, 14);
            this.depthTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.depthTextBox.Name = "depthTextBox";
            this.depthTextBox.Size = new System.Drawing.Size(39, 23);
            this.depthTextBox.TabIndex = 2;
            this.depthTextBox.Text = "8";
            this.depthTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 17);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Depth:";
            // 
            // drawButton
            // 
            this.drawButton.Location = new System.Drawing.Point(162, 11);
            this.drawButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.drawButton.Name = "drawButton";
            this.drawButton.Size = new System.Drawing.Size(88, 27);
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
            this.curvePictureBox.Location = new System.Drawing.Point(18, 44);
            this.curvePictureBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.curvePictureBox.Name = "curvePictureBox";
            this.curvePictureBox.Size = new System.Drawing.Size(380, 357);
            this.curvePictureBox.TabIndex = 11;
            this.curvePictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.AcceptButton = this.drawButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 415);
            this.Controls.Add(this.curvePictureBox);
            this.Controls.Add(this.drawButton);
            this.Controls.Add(this.depthTextBox);
            this.Controls.Add(this.label5);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "hilbert_fractal";
            ((System.ComponentModel.ISupportInitialize)(this.curvePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox depthTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button drawButton;
        private System.Windows.Forms.PictureBox curvePictureBox;
    }
}

