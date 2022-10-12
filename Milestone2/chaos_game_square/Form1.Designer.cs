namespace chaos_game_square
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
            this.label1 = new System.Windows.Forms.Label();
            this.restrictionComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.chaosPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(335, 12);
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
            this.chaosPictureBox.Size = new System.Drawing.Size(400, 400);
            this.chaosPictureBox.TabIndex = 1;
            this.chaosPictureBox.TabStop = false;
            // 
            // dotsTimer
            // 
            this.dotsTimer.Tick += new System.EventHandler(this.dotsTimer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Restriction:";
            // 
            // restrictionComboBox
            // 
            this.restrictionComboBox.FormattingEnabled = true;
            this.restrictionComboBox.Items.AddRange(new object[] {
            "None",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.restrictionComboBox.Location = new System.Drawing.Point(93, 13);
            this.restrictionComboBox.Name = "restrictionComboBox";
            this.restrictionComboBox.Size = new System.Drawing.Size(121, 23);
            this.restrictionComboBox.TabIndex = 3;
            this.restrictionComboBox.Text = "None";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 488);
            this.Controls.Add(this.restrictionComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chaosPictureBox);
            this.Controls.Add(this.startButton);
            this.Name = "Form1";
            this.Text = "chaos_game_square";
            ((System.ComponentModel.ISupportInitialize)(this.chaosPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button startButton;
        private PictureBox chaosPictureBox;
        private System.Windows.Forms.Timer dotsTimer;
        private Label label1;
        private ComboBox restrictionComboBox;
    }
}