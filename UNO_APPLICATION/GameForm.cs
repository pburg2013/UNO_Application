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
    public partial class PlayGame : Form
    {
       
        public GameSystem unogame = new GameSystem();
        public MainMenu RefToMainMenu;
        string initials { get; set; }
        
        public PlayGame(MainMenu mainmenu, string color)
        {
            
            InitializeComponent();
            this.RefToMainMenu = mainmenu;
            unogame.option_card = color;
            initials = "";
           

            if (color == "green_back.png")
            {
                DrawPilePic.Image = UNO_APPLICATION.Properties.Resources.green_back;
            }
            else if (color == "blue_back.png")
            {
                DrawPilePic.Image = UNO_APPLICATION.Properties.Resources.blue_back;
            }
            else
            {
                DrawPilePic.Image = UNO_APPLICATION.Properties.Resources.red_back;
            }
            DrawPilePic.SizeMode = PictureBoxSizeMode.StretchImage;
            //  unogame.userinitials = ShowDialog("Enter you initials", "Welcome to Ultimate UNO!");
            //  NameBox.Text = "Number of cards"+ System.Environment.NewLine + unogame.userinitials +  ": " + 0 + " Opponent: " + 10;


         
           unogame.PlayGame(this);

        }
   
       
       
       
        public string GetInitials()
        {
            if(initials=="")
                 initials = ShowDialog("Enter your initials ", "Welcome to User!");
            return initials;
        }
        public static string ShowDialog(string text, string caption)
        {
            Form prompt = new Form()
            {
                Width = 500,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = caption,
                StartPosition = FormStartPosition.CenterScreen
            };
            Label textLabel = new Label() { Left = 50, Top = 20, Text = text };
            TextBox textBox = new TextBox() { Left = 50, Top = 50, Width = 400 };
            Button confirmation = new Button() { Text = "Ok", Left = 350, Width = 100, Top = 70, DialogResult = DialogResult.OK };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.AcceptButton = confirmation;

            return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.RefToMainMenu.Show();
        }

       public void LockControls(Control back_button)
        {
            foreach (Control c in this.Controls)
            {
                c.Enabled = false;
            }
            if (back_button != null)
            {
                back_button.Enabled = true;
            }
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Every player views his/her cards and tries to match the card in the Discard Pile." + Environment.NewLine + "You have to match either by the number, color, or the symbol/Action" + Environment.NewLine + "If the player has no matches or they choose not to play any of their cards even though they might have a match, they must draw a card from the Draw pile." + Environment.NewLine + " If that card can be played, play it. Otherwise, the game moves on to the next person in turn. You can also play a Wild card, or a Wild Draw Four card on your turn." + Environment.NewLine + "Players continue to draw cards until they have a match." + Environment.NewLine);

        }
    }
}

