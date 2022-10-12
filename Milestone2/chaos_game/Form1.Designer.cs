namespace chaos_game
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.startButton = new System.Windows.Forms.Button();
            this.chaosPictureBox = new System.Windows.Forms.PictureBox();
            this.dotsTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chaosPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(364, 12);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // chaosPictureBox
            // 
            this.chaosPictureBox.Location = new System.Drawing.Point(12, 55);
            this.chaosPictureBox.Name = "chaosPictureBox";
            this.chaosPictureBox.Size = new System.Drawing.Size(776, 383);
            this.chaosPictureBox.TabIndex = 1;
            this.chaosPictureBox.TabStop = false;
            // 
            // dotsTimer
            // 
            this.dotsTimer.Tick += new System.EventHandler(this.dotsTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chaosPictureBox);
            this.Controls.Add(this.startButton);
            this.Name = "Form1";
            this.Text = "chaos_game";
            ((System.ComponentModel.ISupportInitialize)(this.chaosPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button startButton;
        private PictureBox chaosPictureBox;
        private System.Windows.Forms.Timer dotsTimer;
    }
}