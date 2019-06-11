namespace WindowsFormsApp4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BtnNextDay = new System.Windows.Forms.Button();
            this.LbxInfo = new System.Windows.Forms.ListBox();
            this.BtnPlayAgain = new System.Windows.Forms.Button();
            this.BtnUmbrella = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.LblUmbrella = new System.Windows.Forms.Label();
            this.lblCounter = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnNextDay
            // 
            this.BtnNextDay.Location = new System.Drawing.Point(12, 68);
            this.BtnNextDay.Name = "BtnNextDay";
            this.BtnNextDay.Size = new System.Drawing.Size(153, 45);
            this.BtnNextDay.TabIndex = 0;
            this.BtnNextDay.Text = "Next Day";
            this.BtnNextDay.UseVisualStyleBackColor = true;
            this.BtnNextDay.Click += new System.EventHandler(this.Fire_Click);
            // 
            // LbxInfo
            // 
            this.LbxInfo.FormattingEnabled = true;
            this.LbxInfo.Location = new System.Drawing.Point(54, 236);
            this.LbxInfo.Name = "LbxInfo";
            this.LbxInfo.Size = new System.Drawing.Size(173, 95);
            this.LbxInfo.TabIndex = 2;
            // 
            // BtnPlayAgain
            // 
            this.BtnPlayAgain.Location = new System.Drawing.Point(12, 12);
            this.BtnPlayAgain.Name = "BtnPlayAgain";
            this.BtnPlayAgain.Size = new System.Drawing.Size(110, 36);
            this.BtnPlayAgain.TabIndex = 3;
            this.BtnPlayAgain.Text = "Play Again?";
            this.BtnPlayAgain.UseVisualStyleBackColor = true;
            this.BtnPlayAgain.Click += new System.EventHandler(this.BtnPlayAgain_Click);
            // 
            // BtnUmbrella
            // 
            this.BtnUmbrella.Location = new System.Drawing.Point(12, 170);
            this.BtnUmbrella.Name = "BtnUmbrella";
            this.BtnUmbrella.Size = new System.Drawing.Size(154, 44);
            this.BtnUmbrella.TabIndex = 4;
            this.BtnUmbrella.Text = "Use Umbrella";
            this.BtnUmbrella.UseVisualStyleBackColor = true;
            this.BtnUmbrella.Click += new System.EventHandler(this.Duck_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(222, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(404, 332);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(222, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(404, 332);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Day 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Day 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Day 3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Day 4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 288);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Day 5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 301);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Day 6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 314);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Day 7";
            // 
            // LblUmbrella
            // 
            this.LblUmbrella.AutoSize = true;
            this.LblUmbrella.Location = new System.Drawing.Point(172, 186);
            this.LblUmbrella.Name = "LblUmbrella";
            this.LblUmbrella.Size = new System.Drawing.Size(0, 13);
            this.LblUmbrella.TabIndex = 16;
            this.LblUmbrella.Click += new System.EventHandler(this.Label8_Click);
            // 
            // lblCounter
            // 
            this.lblCounter.AutoSize = true;
            this.lblCounter.Location = new System.Drawing.Point(165, 186);
            this.lblCounter.Name = "lblCounter";
            this.lblCounter.Size = new System.Drawing.Size(51, 13);
            this.lblCounter.TabIndex = 17;
            this.lblCounter.Text = "2/2 Uses";
            this.lblCounter.Click += new System.EventHandler(this.LblCounter_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(638, 356);
            this.Controls.Add(this.lblCounter);
            this.Controls.Add(this.LblUmbrella);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnUmbrella);
            this.Controls.Add(this.BtnPlayAgain);
            this.Controls.Add(this.LbxInfo);
            this.Controls.Add(this.BtnNextDay);
            this.Name = "Form1";
            this.Text = "Umbrella Game by Sam Moake";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnNextDay;
        private System.Windows.Forms.ListBox LbxInfo;
        private System.Windows.Forms.Button BtnPlayAgain;
        private System.Windows.Forms.Button BtnUmbrella;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label LblUmbrella;
        private System.Windows.Forms.Label lblCounter;
    }
}

