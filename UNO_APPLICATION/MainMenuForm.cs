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
    public partial class MainMenu : Form
    {
        Options optionform;
        PlayGame gameform;
        HighScores highscoreform;
        public MainMenu()
        {
            InitializeComponent();
        
           // gameform = new Game(this);
           // optionform.Hide();
           // gameform.Hide();

        }
        //Create all other forms 
         
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void OptionButton_Click(object sender, EventArgs e)
        {
            optionform = new Options(this);
            optionform.FormClosed += new FormClosedEventHandler(optionform_FormClosed);
            this.Hide();
            optionform.Show();
        }
        private void optionform_FormClosed(object sender, FormClosedEventArgs e)
        {
           
            this.Close();
        }
        private void gameform_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
        private void highscoreform_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void PlayGameButton_Click(object sender, EventArgs e)
        {
            gameform = new PlayGame(this,global.unogame.option_card);
            gameform.FormClosed += new FormClosedEventHandler(gameform_FormClosed);
            gameform.StartPosition = FormStartPosition.CenterParent;
            this.Hide();
           gameform.Show();
        }

        private void HighScoresButton_Click(object sender, EventArgs e)
        {
            highscoreform = new HighScores(this);
            highscoreform.FormClosed += new FormClosedEventHandler(highscoreform_FormClosed);
            highscoreform.StartPosition = FormStartPosition.CenterParent;
            this.Hide();
            highscoreform.Show();
        }

        private void ReadRulesButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Every player views his/her cards and tries to match the card in the Discard Pile." + Environment.NewLine + "You have to match either by the number, color, or the symbol/Action" + Environment.NewLine + "If the player has no matches or they choose not to play any of their cards even though they might have a match, they must draw a card from the Draw pile." + Environment.NewLine + " If that card can be played, play it. Otherwise, the game moves on to the next person in turn. You can also play a Wild card, or a Wild Draw Four card on your turn." + Environment.NewLine + "Players continue to draw cards until they have a match." + Environment.NewLine);
        }
    }
    public static class global
    {
        public static GameSystem unogame = new GameSystem();
    }
}
    

