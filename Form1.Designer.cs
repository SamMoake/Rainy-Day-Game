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
            this.GifUmbrella = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GifUmbrella)).BeginInit();
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
            this.LbxInfo.Location = new System.Drawing.Point(12, 236);
            this.LbxInfo.Name = "LbxInfo";
            this.LbxInfo.Size = new System.Drawing.Size(614, 108);
            this.LbxInfo.TabIndex = 2;
            this.LbxInfo.SelectedIndexChanged += new System.EventHandler(this.LbxInfo_SelectedIndexChanged);
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
            // GifUmbrella
            // 
            this.GifUmbrella.InitialImage = ((System.Drawing.Image)(resources.GetObject("GifUmbrella.InitialImage")));
            this.GifUmbrella.Location = new System.Drawing.Point(312, 68);
            this.GifUmbrella.Name = "GifUmbrella";
            this.GifUmbrella.Size = new System.Drawing.Size(314, 152);
            this.GifUmbrella.TabIndex = 5;
            this.GifUmbrella.TabStop = false;
            this.GifUmbrella.Click += new System.EventHandler(this.GifUmbrella_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(172, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(638, 356);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GifUmbrella);
            this.Controls.Add(this.BtnUmbrella);
            this.Controls.Add(this.BtnPlayAgain);
            this.Controls.Add(this.LbxInfo);
            this.Controls.Add(this.BtnNextDay);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.GifUmbrella)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnNextDay;
        private System.Windows.Forms.ListBox LbxInfo;
        private System.Windows.Forms.Button BtnPlayAgain;
        private System.Windows.Forms.Button BtnUmbrella;
        private System.Windows.Forms.PictureBox GifUmbrella;
        private System.Windows.Forms.Label label1;
    }
}

