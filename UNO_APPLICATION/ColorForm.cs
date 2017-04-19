using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UNO_APPLICATION
{
    public partial class ColorForm : Form
    {
        public string color { get; set; } 
        public  ColorForm()
        {
            InitializeComponent();
            

        }
        

        private void redbutton_Click(object sender, EventArgs e)
        {
            this.color = "red";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void bluebutton_Click(object sender, EventArgs e)
        {
            this.color = "blue";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void greenbutton_Click(object sender, EventArgs e)
        {
            this.color = "green";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void yellowbutton_Click(object sender, EventArgs e)
        {
            this.color = "yellow";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
