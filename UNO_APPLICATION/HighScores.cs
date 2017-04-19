using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace UNO_APPLICATION
{
    public partial class HighScores : Form
    {
        public MainMenu RefToMainMenu { get; set; }
        public HighScores(MainMenu mainmenu)
        {
            this.RefToMainMenu = mainmenu;
            InitializeComponent();
            Display_Highscores();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            RefToMainMenu.Show();
        }
        public List<string> highscoresList = new List<string>();
        public void Display_Highscores()
        {
            string path = Path.GetDirectoryName(Path.GetDirectoryName(Directory.GetCurrentDirectory())) + "\\Highscores.txt";
            string[] highscoresList = File.ReadAllLines(path);
            foreach(string s in highscoresList)
            {
                textBox1.Text += s + Environment.NewLine;
            }

               
        }
    }
}
