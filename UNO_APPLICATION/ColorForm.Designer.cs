namespace UNO_APPLICATION
{
    partial class ColorForm
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
            this.redbutton = new System.Windows.Forms.Button();
            this.bluebutton = new System.Windows.Forms.Button();
            this.greenbutton = new System.Windows.Forms.Button();
            this.yellowbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // redbutton
            // 
            this.redbutton.BackColor = System.Drawing.Color.Red;
            this.redbutton.Location = new System.Drawing.Point(1, 12);
            this.redbutton.Name = "redbutton";
            this.redbutton.Size = new System.Drawing.Size(75, 23);
            this.redbutton.TabIndex = 0;
            this.redbutton.UseVisualStyleBackColor = false;
            this.redbutton.Click += new System.EventHandler(this.redbutton_Click);
            // 
            // bluebutton
            // 
            this.bluebutton.BackColor = System.Drawing.Color.Blue;
            this.bluebutton.Location = new System.Drawing.Point(82, 12);
            this.bluebutton.Name = "bluebutton";
            this.bluebutton.Size = new System.Drawing.Size(75, 23);
            this.bluebutton.TabIndex = 1;
            this.bluebutton.UseVisualStyleBackColor = false;
            this.bluebutton.Click += new System.EventHandler(this.bluebutton_Click);
            // 
            // greenbutton
            // 
            this.greenbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.greenbutton.Location = new System.Drawing.Point(163, 12);
            this.greenbutton.Name = "greenbutton";
            this.greenbutton.Size = new System.Drawing.Size(75, 23);
            this.greenbutton.TabIndex = 2;
            this.greenbutton.UseVisualStyleBackColor = false;
            this.greenbutton.Click += new System.EventHandler(this.greenbutton_Click);
            // 
            // yellowbutton
            // 
            this.yellowbutton.BackColor = System.Drawing.Color.Yellow;
            this.yellowbutton.Location = new System.Drawing.Point(244, 12);
            this.yellowbutton.Name = "yellowbutton";
            this.yellowbutton.Size = new System.Drawing.Size(75, 23);
            this.yellowbutton.TabIndex = 3;
            this.yellowbutton.UseVisualStyleBackColor = false;
            this.yellowbutton.Click += new System.EventHandler(this.yellowbutton_Click);
            // 
            // ColorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 41);
            this.Controls.Add(this.yellowbutton);
            this.Controls.Add(this.greenbutton);
            this.Controls.Add(this.bluebutton);
            this.Controls.Add(this.redbutton);
            this.Name = "ColorForm";
            this.Text = "ColorForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button redbutton;
        private System.Windows.Forms.Button bluebutton;
        private System.Windows.Forms.Button greenbutton;
        private System.Windows.Forms.Button yellowbutton;
    }
}