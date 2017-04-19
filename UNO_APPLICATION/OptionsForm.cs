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
    
    public partial class Options : Form
    {
        public MainMenu RefToMainMenu { get; set; }
        public Options(MainMenu mainmenu)
        {
            InitializeComponent();
            this.RefToMainMenu = mainmenu;
            
        }
       
        private void button4_Click(object sender, EventArgs e)
        {
           
            this.Hide();
            this.RefToMainMenu.Show();
        }
        private void menuform_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void redback_Click(object sender, EventArgs e)
        {
            textBox2.Text = "Color Chosen:" + " RED";
            global.unogame.option_card = "red_back.png";
        }

        private void blueback_Click(object sender, EventArgs e)
        {
            textBox2.Text = "Color Chosen:" + " BLUE";
            global.unogame.option_card = "blue_back.png";

        }
        private void greenback_Click(object sender, EventArgs e)
        {
            textBox2.Text = "Color Chosen:" + " GREEN";
            global.unogame.option_card = "green_back.png";
        }

        
    }
}
