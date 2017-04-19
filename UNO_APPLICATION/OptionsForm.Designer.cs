namespace UNO_APPLICATION
{
    partial class Options
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Options));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.redback = new System.Windows.Forms.PictureBox();
            this.blueback = new System.Windows.Forms.PictureBox();
            this.greenback = new System.Windows.Forms.PictureBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redback)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueback)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenback)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Maroon;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(54, 98);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(298, 35);
            this.textBox1.TabIndex = 0;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "Choose new card back design. ";
            // 
            // button4
            // 
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(20, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(50, 23);
            this.button4.TabIndex = 9;
            this.button4.Text = "Back";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.InitialImage = null;
            this.pictureBox5.Location = new System.Drawing.Point(116, 4);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(256, 88);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 5;
            this.pictureBox5.TabStop = false;
            // 
            // redback
            // 
            this.redback.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.redback.Image = global::UNO_APPLICATION.Properties.Resources.red_back;
            this.redback.Location = new System.Drawing.Point(20, 129);
            this.redback.Name = "redback";
            this.redback.Size = new System.Drawing.Size(96, 119);
            this.redback.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.redback.TabIndex = 10;
            this.redback.TabStop = false;
            this.redback.Click += new System.EventHandler(this.redback_Click);
            // 
            // blueback
            // 
            this.blueback.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.blueback.Image = global::UNO_APPLICATION.Properties.Resources.blue_back;
            this.blueback.Location = new System.Drawing.Point(151, 129);
            this.blueback.Name = "blueback";
            this.blueback.Size = new System.Drawing.Size(96, 119);
            this.blueback.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.blueback.TabIndex = 11;
            this.blueback.TabStop = false;
            this.blueback.Click += new System.EventHandler(this.blueback_Click);
            // 
            // greenback
            // 
            this.greenback.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.greenback.Image = global::UNO_APPLICATION.Properties.Resources.green_back;
            this.greenback.Location = new System.Drawing.Point(288, 129);
            this.greenback.Name = "greenback";
            this.greenback.Size = new System.Drawing.Size(96, 119);
            this.greenback.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.greenback.TabIndex = 12;
            this.greenback.TabStop = false;
            this.greenback.Click += new System.EventHandler(this.greenback_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Maroon;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox2.Location = new System.Drawing.Point(129, 254);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(153, 13);
            this.textBox2.TabIndex = 13;
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(402, 280);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.greenback);
            this.Controls.Add(this.blueback);
            this.Controls.Add(this.redback);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.textBox1);
            this.Name = "Options";
            this.Text = "Options";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redback)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueback)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenback)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox redback;
        private System.Windows.Forms.PictureBox blueback;
        private System.Windows.Forms.PictureBox greenback;
        private System.Windows.Forms.TextBox textBox2;
    }
}