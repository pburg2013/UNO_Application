namespace UNO_APPLICATION
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.unologo = new System.Windows.Forms.PictureBox();
            this.PlayGameButton = new System.Windows.Forms.Button();
            this.ReadRulesButton = new System.Windows.Forms.Button();
            this.OptionButton = new System.Windows.Forms.Button();
            this.HighScoresButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.unologo)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Maroon;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Segoe Print", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(25, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(251, 43);
            this.textBox1.TabIndex = 0;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "Welcome to";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Maroon;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox2.Location = new System.Drawing.Point(104, 109);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(189, 21);
            this.textBox2.TabIndex = 1;
            this.textBox2.TabStop = false;
            this.textBox2.Text = "Choose an Option";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // unologo
            // 
            this.unologo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.unologo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.unologo.Image = ((System.Drawing.Image)(resources.GetObject("unologo.Image")));
            this.unologo.InitialImage = null;
            this.unologo.Location = new System.Drawing.Point(183, 12);
            this.unologo.Name = "unologo";
            this.unologo.Size = new System.Drawing.Size(224, 98);
            this.unologo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.unologo.TabIndex = 2;
            this.unologo.TabStop = false;
            // 
            // PlayGameButton
            // 
            this.PlayGameButton.Location = new System.Drawing.Point(163, 136);
            this.PlayGameButton.Name = "PlayGameButton";
            this.PlayGameButton.Size = new System.Drawing.Size(75, 25);
            this.PlayGameButton.TabIndex = 3;
            this.PlayGameButton.Text = "Play Game";
            this.PlayGameButton.UseMnemonic = false;
            this.PlayGameButton.UseVisualStyleBackColor = true;
            this.PlayGameButton.Click += new System.EventHandler(this.PlayGameButton_Click);
            // 
            // ReadRulesButton
            // 
            this.ReadRulesButton.Location = new System.Drawing.Point(163, 195);
            this.ReadRulesButton.Name = "ReadRulesButton";
            this.ReadRulesButton.Size = new System.Drawing.Size(75, 23);
            this.ReadRulesButton.TabIndex = 4;
            this.ReadRulesButton.Text = "Read Rules";
            this.ReadRulesButton.UseMnemonic = false;
            this.ReadRulesButton.UseVisualStyleBackColor = true;
            this.ReadRulesButton.Click += new System.EventHandler(this.ReadRulesButton_Click);
            // 
            // OptionButton
            // 
            this.OptionButton.Location = new System.Drawing.Point(163, 167);
            this.OptionButton.Name = "OptionButton";
            this.OptionButton.Size = new System.Drawing.Size(75, 22);
            this.OptionButton.TabIndex = 5;
            this.OptionButton.Text = "Options";
            this.OptionButton.UseVisualStyleBackColor = true;
            this.OptionButton.Click += new System.EventHandler(this.OptionButton_Click);
            // 
            // HighScoresButton
            // 
            this.HighScoresButton.Location = new System.Drawing.Point(163, 224);
            this.HighScoresButton.Name = "HighScoresButton";
            this.HighScoresButton.Size = new System.Drawing.Size(75, 23);
            this.HighScoresButton.TabIndex = 6;
            this.HighScoresButton.Text = "High Scores";
            this.HighScoresButton.UseVisualStyleBackColor = true;
            this.HighScoresButton.Click += new System.EventHandler(this.HighScoresButton_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(419, 286);
            this.Controls.Add(this.HighScoresButton);
            this.Controls.Add(this.OptionButton);
            this.Controls.Add(this.ReadRulesButton);
            this.Controls.Add(this.PlayGameButton);
            this.Controls.Add(this.unologo);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainMenu";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.unologo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.PictureBox unologo;
        private System.Windows.Forms.Button PlayGameButton;
        private System.Windows.Forms.Button ReadRulesButton;
        private System.Windows.Forms.Button OptionButton;
        private System.Windows.Forms.Button HighScoresButton;
    }
}

