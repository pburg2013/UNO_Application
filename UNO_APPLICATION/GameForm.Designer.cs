namespace UNO_APPLICATION
{
    partial class PlayGame
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.DrawPilePic = new System.Windows.Forms.PictureBox();
            this.CardCountBox = new System.Windows.Forms.TextBox();
            this.DiscardPileImage = new System.Windows.Forms.PictureBox();
            this.DiscardPileText = new System.Windows.Forms.TextBox();
            this.DrawPileText = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.HandPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.feedbox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DrawPilePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiscardPileImage)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DrawPilePic
            // 
            this.DrawPilePic.Location = new System.Drawing.Point(318, 48);
            this.DrawPilePic.Name = "DrawPilePic";
            this.DrawPilePic.Size = new System.Drawing.Size(82, 104);
            this.DrawPilePic.TabIndex = 1;
            this.DrawPilePic.TabStop = false;
            // 
            // CardCountBox
            // 
            this.CardCountBox.BackColor = System.Drawing.Color.Maroon;
            this.CardCountBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CardCountBox.ForeColor = System.Drawing.SystemColors.Window;
            this.CardCountBox.Location = new System.Drawing.Point(116, 5);
            this.CardCountBox.Multiline = true;
            this.CardCountBox.Name = "CardCountBox";
            this.CardCountBox.Size = new System.Drawing.Size(213, 37);
            this.CardCountBox.TabIndex = 2;
            // 
            // DiscardPileImage
            // 
            this.DiscardPileImage.Location = new System.Drawing.Point(172, 48);
            this.DiscardPileImage.Name = "DiscardPileImage";
            this.DiscardPileImage.Size = new System.Drawing.Size(82, 104);
            this.DiscardPileImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DiscardPileImage.TabIndex = 4;
            this.DiscardPileImage.TabStop = false;
            // 
            // DiscardPileText
            // 
            this.DiscardPileText.BackColor = System.Drawing.Color.Maroon;
            this.DiscardPileText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DiscardPileText.ForeColor = System.Drawing.SystemColors.Window;
            this.DiscardPileText.Location = new System.Drawing.Point(184, 158);
            this.DiscardPileText.Name = "DiscardPileText";
            this.DiscardPileText.Size = new System.Drawing.Size(70, 13);
            this.DiscardPileText.TabIndex = 5;
            this.DiscardPileText.Text = "Discard Pile";
            this.DiscardPileText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DrawPileText
            // 
            this.DrawPileText.BackColor = System.Drawing.Color.Maroon;
            this.DrawPileText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DrawPileText.ForeColor = System.Drawing.SystemColors.Window;
            this.DrawPileText.Location = new System.Drawing.Point(318, 158);
            this.DrawPileText.Name = "DrawPileText";
            this.DrawPileText.Size = new System.Drawing.Size(70, 13);
            this.DrawPileText.TabIndex = 7;
            this.DrawPileText.Text = "Draw Pile";
            this.DrawPileText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Maroon;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(3, 48);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(133, 39);
            this.textBox1.TabIndex = 8;
            // 
            // HandPanel
            // 
            this.HandPanel.AutoScroll = true;
            this.HandPanel.Location = new System.Drawing.Point(12, 177);
            this.HandPanel.Name = "HandPanel";
            this.HandPanel.Size = new System.Drawing.Size(551, 199);
            this.HandPanel.TabIndex = 9;
            // 
            // feedbox
            // 
            this.feedbox.BackColor = System.Drawing.Color.Maroon;
            this.feedbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.feedbox.ForeColor = System.Drawing.Color.White;
            this.feedbox.Location = new System.Drawing.Point(12, 109);
            this.feedbox.Multiline = true;
            this.feedbox.Name = "feedbox";
            this.feedbox.ReadOnly = true;
            this.feedbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.feedbox.Size = new System.Drawing.Size(124, 62);
            this.feedbox.TabIndex = 10;
            this.feedbox.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(460, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Read Rules";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // PlayGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(575, 388);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.feedbox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.HandPanel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.DrawPileText);
            this.Controls.Add(this.DiscardPileText);
            this.Controls.Add(this.DiscardPileImage);
            this.Controls.Add(this.CardCountBox);
            this.Controls.Add(this.DrawPilePic);
            this.Name = "PlayGame";
            this.Text = "Play Game";
            ((System.ComponentModel.ISupportInitialize)(this.DrawPilePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiscardPileImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.PictureBox DrawPilePic;
        public System.Windows.Forms.TextBox CardCountBox;
        public System.Windows.Forms.PictureBox DiscardPileImage;
        private System.Windows.Forms.TextBox DiscardPileText;
        private System.Windows.Forms.TextBox DrawPileText;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.FlowLayoutPanel HandPanel;
        public System.Windows.Forms.ToolTip toolTip1;
        public System.Windows.Forms.TextBox feedbox;
        private System.Windows.Forms.Button button2;
        // public System.Windows.Forms.ToolTip toolTip1;
    }
}