using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace UNO_APPLICATION
{
    public struct highscore
    {
        public int value;
        public string player_initials;
        public highscore(int val, string initials)
        {
            value = val;
            player_initials = initials;
        }
    };
    public class GameSystem
    {
        List<Player> players = new List<Player>();//List of players
        public Discard_Pile discardpile = new Discard_Pile();//create discard pile
        public Draw_Pile drawpile = new Draw_Pile();//create draw pile
        //Validation class
        private List<highscore> highscores = new List<highscore>();//create list of highscores
        public string userinitials { get; set; }
        //This will address the location of the image file
        //Default is red
        public string option_card { get; set; }
        //Score is calculated from the PlayGame method
        public int winning_score = 0;
        //Winning player is chosen by PlayGame method
        // public int winning_player;
        public Card top_card; //used to hold the top card of discard pile
        public Card play_card { get; set; } //used to save the card that the player will play
        int turn = 1; //keep track of turns
        bool validated = false; // used to see if a card is verified to play
        string opponent_feedback { get; set; }
      
        TextBox messagebox { get; set; }
        FlowLayoutPanel handpanel { get; set; }
        ToolTip tip { get; set; }
        PictureBox discardpic { get; set; }
        TextBox countbox { get; set; }
        PictureBox drawpilepic { get; set;}
        int time = 1000;
        PlayGame gform { get; set; }
        TextBox feedback { get; set; }

        public void PlayGame(PlayGame gameform)
        {
            gform = gameform;
            messagebox = gameform.textBox1;
            handpanel = gameform.HandPanel;
            discardpic = gameform.DiscardPileImage;
            drawpilepic = gameform.DrawPilePic;
            drawpilepic.Click += new EventHandler(drawpile_click);
            feedback = gameform.feedbox;
            countbox = gameform.CardCountBox;
            tip = gameform.toolTip1;
            handpanel.Visible = true;
            //Create new deck in draw pile
            drawpile.add_deck();
            drawpile.shuffle_deck();
            //getting user input for the initials
            userinitials = gameform.GetInitials();

            getHighscores();
         //   PutTaskDelay("Welcome to Ultimate UNO, " + userinitials + "!" + Environment.NewLine + "Lets Start the game!");
            players.Clear();
           
            //create two players
            players.Add(new Player());
            players.Add(new Player(userinitials));

            for (int i = 0; i < 7; i++)
            {
                //Adding 7 cards to each player
                players[0].draw_newcard(drawpile.draw_card());
                players[1].draw_newcard(drawpile.draw_card());
            }
          
            update_CardCount(countbox, players[1].num_cards, players[0].num_cards);

           
           
            do
            {
                //Placing the first card down, if it is a action/wild/wild4 card keep placing a card down
                top_card = drawpile.draw_card();
                discardpile.add_card(top_card);
            } while (top_card.type == "action" || top_card.type == "wild4" || top_card.type == "wild");
            //set the first top card image
            update_DiscardPileImage(discardpic, getImage(top_card), gameform.toolTip1, top_card);

             Users_Turn();
           
           


          

        }
        async void PutTaskDelay( string message)
        {
           
           // await Task.Delay(time);
            messagebox.Text = message;
            await Task.Delay(time);
            messagebox.Update();
            time += 2000;
   
       
        

        }
        public void check_drawpile()
        {
            if (drawpile.num_cards <= 15)
            {
                while (discardpile.num_cards != 0)
                {
                    drawpile.add_card(discardpile.get_topcard());
                }
                drawpile.shuffle_deck();
                discardpile.add_card(top_card);
            }
        }
        public void Users_Turn()
        {
            feedback.Text = opponent_feedback;
            PutTaskDelay("Your Turn..");
            Display_Hand(tip);
        }
        
        public void update_CardCount(TextBox text, int player1, int player2)
        {
            text.Text = userinitials + ": " + player1 + " Opponent: " + player2 + " ";
        }
        public void update_DiscardPileImage(PictureBox discard,Image new_card, ToolTip tip, Card top )
        {
            try
            {
                discard.Image = new_card;
            }catch(Exception ex)
            {
                update_DiscardPileImage(discard, new_card, tip, top);
            }
            discard.SizeMode = PictureBoxSizeMode.StretchImage;
            tip.SetToolTip(discard, top.Output());

        }
        public void Display_Hand(ToolTip tip)
        {
            handpanel.Visible = true;

        /*    List<Button> buttons = handpanel.Controls.OfType<Button>().ToList();
            //erase all the controls first 
            handpanel.Visible = false;
            foreach (Control item in buttons)
            {
                handpanel.Controls.Remove(item);
                item.Dispose();
            }

            for (int i = 0; i < players[1].num_cards; i++)
            {
                Button new_pic = new Button();
                new_pic.Height = 70;
                new_pic.Width = 70;
                new_pic.Name = i.ToString();
                new_pic.BackgroundImage = getImage(players[1].hand[i]);
                if (new_pic.BackgroundImage != null)
                    new_pic.BackgroundImageLayout = ImageLayout.Stretch;
                new_pic.Click += new EventHandler(card_pick);
                handpanel.Controls.Add(new_pic);
                tip.SetToolTip(new_pic, players[1].hand[i].Output());
            }*/
            List<PictureBox> buttons = handpanel.Controls.OfType<PictureBox>().ToList();
            //erase all the controls first 
         //   handpanel.Visible = false;
            foreach (Control item in buttons)
            {
                handpanel.Controls.Remove(item);
                item.Dispose();
               
           }

            for (int i = 0; i < players[1].num_cards; i++)
            {
                PictureBox new_pic = new PictureBox();
                new_pic.Height = 70;
                new_pic.Width = 70;
                new_pic.Name = i.ToString();
                new_pic.Image = getImage(players[1].hand[i]);
                if (new_pic.Image != null)
                    new_pic.SizeMode = PictureBoxSizeMode.StretchImage;
                new_pic.Click += new EventHandler(card_pick);
                try
                {
                    handpanel.Controls.Add(new_pic);
                }catch(Exception ex)
                {
                    //System.Threading.Thread.Sleep(200);

                    Users_Turn();
                   // MessageBox.Show("Error: " );
                }
               
                tip.SetToolTip(new_pic, players[1].hand[i].Output());
            }
         //   handpanel.Visible = true;
           // return;
        }
        private void card_pick(Object sender, EventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            int choice = Convert.ToInt32(pic.Name);
            this.play_card = players[1].hand[choice];
         
           // PutTaskDelay("You chose: " + play_card.Output());
          //  handpanel.Visible = false;
            //validate card
            validated = validate_card(top_card, play_card);
           if( validated )
            {
                top_card = play_card;
                discardpile.add_card(play_card);
                update_DiscardPileImage(discardpic, getImage(top_card), tip, top_card);
                players[1].remove_card(play_card);
                handpanel.Controls.Remove(pic);
                if (players[1].num_cards == 0)
                {
                    Display_Winner(players[1]);
                    update_CardCount(countbox, players[1].num_cards, players[0].num_cards);
                    return;
                }
                   
                update_CardCount(countbox, players[1].num_cards, players[0].num_cards);
                if (top_card.type == "action")
                {//if player played these actions then do nothing, do no decrement turn
                    if (top_card.action == "drawtwo")
                    {
                        players[0].draw_newcard(drawpile.draw_card());
                        players[0].draw_newcard(drawpile.draw_card());
                        update_CardCount(countbox, players[1].num_cards, players[0].num_cards);
                    }

                }
                else if (top_card.type == "wild" || top_card.type == "wild4")
                {
                    Display_Hand(tip);
                    //user has to decide on the color for the card
                    ColorForm colorform = new ColorForm();
                    colorform.StartPosition = FormStartPosition.CenterParent;
                    var result = colorform.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                       
                       // PutTaskDelay("You chose the color: " + colorform.color);
                        
                        top_card.color = colorform.color;
                        update_DiscardPileImage(discardpic, getImage(top_card), tip, top_card);
                    }
                    if (top_card.drawFour)
                    {//give opponent 4 cards if DrawFour is played
                        for (int i = 0; i < 4; i++)
                            players[0].draw_newcard(drawpile.draw_card());
                        update_CardCount(countbox, players[1].num_cards, players[0].num_cards);
                        check_drawpile();
                    }
                    else
                    {//if a wild is played then its the next players turn
                        turn--;
                    }
                }
                else //if a number card is played
                    turn--;

                
                validated = false;
                if (turn == 0)
                {
                    Opponents_Turn();
                    opponent_feedback = "";
                }else
                {
                    Users_Turn();
                }
            }else
            {
                
                PutTaskDelay("Invalid move, try again..");
                Display_Hand(tip);
            }
          
            

        }
        private void drawpile_click(Object sender, EventArgs e)
        {
            players[1].draw_newcard(drawpile.draw_card());
            check_drawpile();
            update_CardCount(countbox, players[1].num_cards, players[0].num_cards);
            Users_Turn();
        }
        public void Display_Winner(Player winner)
        {
           
            if(winner.initials == "**")
            {
                foreach (Card c in players[1].hand)
                {
                    winning_score += c.value; 
                }
                messagebox.Text = "Im sorry you are the loser " + Environment.NewLine + "The score is: " + winning_score;
              //  PutTaskDelay("I'm sorry you are the loser" + Environment.NewLine + "The score is: " + winning_score);
               // gform.LockControls(gform.button1);
            }else
            {
                foreach (Card c in players[0].hand)
                {
                    winning_score += c.value;
                }
                messagebox.Text = "Congradulations!! You are the winner!" + Environment.NewLine + "The score is: " + winning_score;
                // PutTaskDelay("Congradulations!! You are the winner!" + Environment.NewLine + "The score is: " + winning_score);
                //   gform.LockControls(gform.button1);
                feedback.Text = "";

            }
            handpanel.Visible = false;
            highscores.Add(new highscore(winning_score, winner.initials));
           // string msg = "";

            highscores.Sort((x, y) => y.value - x.value);
           
            string path = Path.GetDirectoryName(Path.GetDirectoryName(Directory.GetCurrentDirectory())) + "\\Highscores.txt";
            File.WriteAllText(path, string.Empty);
                
            StreamWriter file = new StreamWriter(path);
            //
            for(int i = 0;i < highscores.Count(); i++)
            {
                if(i < 5)
                {
                    if (highscores[i].player_initials == winner.initials && highscores[i].value == winning_score && winner.initials!= "**")
                        MessageBox.Show("You reached a highscore!!!");
                    file.WriteLine(highscores[i].player_initials + " "+  highscores[i].value.ToString());
                }
            }
            file.Close();
            drawpilepic.Visible = false;
          
        }
        public void Opponents_Turn()
        {

           
            play_card = players[0].pick_card(top_card);
            while (play_card.type == "invalid")
            {
                //opponent_feedback += "Opponent drawing new card " + Environment.NewLine;
               // PutTaskDelay("Opponent Drawing card...");
                players[0].draw_newcard(drawpile.draw_card());
                play_card = players[0].pick_card(top_card);
            }
            validated = validate_card(top_card, play_card);
            if (validated)
            {
                top_card = play_card;
                opponent_feedback += "Opponent played: " + top_card.Output() + Environment.NewLine;
              //  PutTaskDelay("Opponent played: " + top_card.Output());
                if (top_card.type == "action")
                {
                    if (top_card.action == "drawtwo")
                    {
                        players[1].draw_newcard(drawpile.draw_card());
                        players[1].draw_newcard(drawpile.draw_card());
                        update_CardCount(countbox, players[1].num_cards, players[0].num_cards);
                    }

                }
                else if (top_card.type == "wild" || top_card.type == "wild4")
                {
                    foreach (Card n in players[0].hand)
                    {
                        if (n.type == "number" || n.type == "action")
                        {
                            top_card.color = n.color;
                        }
                    }
                    if (top_card.drawFour)
                    {
                        for (int i = 0; i < 4; i++)
                            players[1].draw_newcard(drawpile.draw_card());

                        update_CardCount(countbox, players[1].num_cards, players[0].num_cards);
                    }
                    else
                    {
                        turn++;
                    }
                }
                else
                    turn++;
                check_drawpile();
                discardpile.add_card(play_card);
                update_DiscardPileImage(discardpic, getImage(top_card), tip, top_card);
                players[0].remove_card(play_card);
                if (players[0].num_cards == 0)
                {
                    Display_Winner(players[0]);
                    update_CardCount(countbox, players[1].num_cards, players[0].num_cards);
                    return;
                }
                   
                update_CardCount(countbox, players[1].num_cards, players[0].num_cards);

                validated = false;
                if (turn == 1)
                    Users_Turn();
                else
                    Opponents_Turn();

            }
            else
                Opponents_Turn();
        }
        public bool validate_card(Card top_card, Card play_card)
        {
            if (play_card.type == "wild" || play_card.type == "wild4")
                return true;
            else if (top_card.type == "number")
            {
                if (play_card.type == "number" && (play_card.color == top_card.color || play_card.num == top_card.num))
                {
                    return true;
                }

                else if (play_card.type == "action" && play_card.color == top_card.color)
                {
                    return true;

                }
                else
                {
                  //  Console.WriteLine("Invalid card, try again.. ");
                    return false;
                }


            }
            else if (top_card.type == "action")
            {
                if (play_card.type == "number" && play_card.color == top_card.color)
                {
                    return true;
                }
                else if (play_card.type == "action" && (play_card.color == top_card.color || play_card.action == top_card.action))
                {
                    return true;
                }
                else
                {
                   // Console.WriteLine("Invalid choice, try again..");
                    return false;
                }

            }
            else if (top_card.type == "wild" || top_card.type == "wild4")
            {
                if (play_card.color == top_card.color)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                //  Console.WriteLine("Invalid choice, try again..");
                return false;
            }

        }
        public void getHighscores()
        {
            //string pinitials;
            // string val;
            List<int> values = new List<int>();
            List<string> initials = new List<string>();
            string path = Path.GetDirectoryName(Path.GetDirectoryName(Directory.GetCurrentDirectory())) + "\\Highscores.txt";
            if (!File.Exists(path))
            {
                FileStream fs = File.Create(path);
                fs.Close();
            }
            StreamReader file = new StreamReader(path);
            string line;
            

            while ((line = file.ReadLine()) != null) {
               
                string[] words = line.Split();
                for(int i=0; i< words.Count(); i++)
                {

                    if (i % 2 == 0)
                        initials.Add(words[i]);
                    else if (i % 2 == 1)
                        values.Add(Convert.ToInt32(words[i]));
                 
                   
                }
            
               
            }
            for (int i = 0; i < initials.Count(); i++)
                highscores.Add(new highscore(values[i], initials[i]));
            file.Close();
        }
        public System.Drawing.Image getImage(Card card)
        {
            if (card.type == "number")
            {
                if (card.color == "green")
                {
                    int num = card.num;
                    switch (num)
                    {
                        case 0:
                            return UNO_APPLICATION.Properties.Resources.green_0;
                        case 1:
                            return UNO_APPLICATION.Properties.Resources.green_1;
                        case 2:
                            return UNO_APPLICATION.Properties.Resources.green_2;
                        case 3:
                            return UNO_APPLICATION.Properties.Resources.green_3;
                        case 4:
                            return UNO_APPLICATION.Properties.Resources.green_4;
                        case 5:
                            return UNO_APPLICATION.Properties.Resources.green_5;
                        case 6:
                            return UNO_APPLICATION.Properties.Resources.green_6;
                        case 7:
                            return UNO_APPLICATION.Properties.Resources.green_7;
                        case 8:
                            return UNO_APPLICATION.Properties.Resources.green_8;
                        case 9:
                            return UNO_APPLICATION.Properties.Resources.green_9;
                        default:
                            return UNO_APPLICATION.Properties.Resources.red_back;

                    }
                }
                else if (card.color == "red")
                {
                    int num = card.num;
                    switch (num)
                    {
                        case 0:
                            return UNO_APPLICATION.Properties.Resources.red_0;
                        case 1:
                            return UNO_APPLICATION.Properties.Resources.red_1;
                        case 2:
                            return UNO_APPLICATION.Properties.Resources.red_2;
                        case 3:
                            return UNO_APPLICATION.Properties.Resources.red_3;
                        case 4:
                            return UNO_APPLICATION.Properties.Resources.red_4;
                        case 5:
                            return UNO_APPLICATION.Properties.Resources.red_5;
                        case 6:
                            return UNO_APPLICATION.Properties.Resources.red_6;
                        case 7:
                            return UNO_APPLICATION.Properties.Resources.red_7;
                        case 8:
                            return UNO_APPLICATION.Properties.Resources.red_8;
                        case 9:
                            return UNO_APPLICATION.Properties.Resources.red_9;
                        default:
                            return UNO_APPLICATION.Properties.Resources.red_back;

                    }
                }
                else if (card.color == "blue")
                {
                    int num = card.num;
                    switch (num)
                    {
                        case 0:
                            return UNO_APPLICATION.Properties.Resources.blue_0;
                        case 1:
                            return UNO_APPLICATION.Properties.Resources.blue_1;
                        case 2:
                            return UNO_APPLICATION.Properties.Resources.blue_2;
                        case 3:
                            return UNO_APPLICATION.Properties.Resources.blue_3;
                        case 4:
                            return UNO_APPLICATION.Properties.Resources.blue_4;
                        case 5:
                            return UNO_APPLICATION.Properties.Resources.blue_5;
                        case 6:
                            return UNO_APPLICATION.Properties.Resources.blue_6;
                        case 7:
                            return UNO_APPLICATION.Properties.Resources.blue_7;
                        case 8:
                            return UNO_APPLICATION.Properties.Resources.blue_8;
                        case 9:
                            return UNO_APPLICATION.Properties.Resources.blue_9;
                        default:
                            return UNO_APPLICATION.Properties.Resources.red_back;

                    }
                }
                else if (card.color == "yellow")
                {
                    int num = card.num;
                    switch (num)
                    {
                        case 0:
                            return UNO_APPLICATION.Properties.Resources.yellow_0;
                        case 1:
                            return UNO_APPLICATION.Properties.Resources.yellow_1;
                        case 2:
                            return UNO_APPLICATION.Properties.Resources.yellow_2;
                        case 3:
                            return UNO_APPLICATION.Properties.Resources.yellow_3;
                        case 4:
                            return UNO_APPLICATION.Properties.Resources.yellow_4;
                        case 5:
                            return UNO_APPLICATION.Properties.Resources.yellow_5;
                        case 6:
                            return UNO_APPLICATION.Properties.Resources.yellow_6;
                        case 7:
                            return UNO_APPLICATION.Properties.Resources.yellow_7;
                        case 8:
                            return UNO_APPLICATION.Properties.Resources.yellow_8;
                        case 9:
                            return UNO_APPLICATION.Properties.Resources.yellow_9;
                        default:
                            return UNO_APPLICATION.Properties.Resources.red_back;

                    }
                }
                else
                    return UNO_APPLICATION.Properties.Resources.red_back;

            }
            else if (card.type == "action")
            {
                if (card.color == "green")
                {
                    if (card.action == "skip")
                        return UNO_APPLICATION.Properties.Resources.green_skip;
                    else if (card.action == "drawtwo")
                        return UNO_APPLICATION.Properties.Resources.green_draw2;
                    else if (card.action == "reverse")
                        return UNO_APPLICATION.Properties.Resources.green_reverse;
                    else
                        return UNO_APPLICATION.Properties.Resources.red_back;
                }
                else if (card.color == "blue")
                {
                    if (card.action == "skip")
                        return UNO_APPLICATION.Properties.Resources.blue_skip;
                    else if (card.action == "drawtwo")
                        return UNO_APPLICATION.Properties.Resources.blue_draw2;
                    else if (card.action == "reverse")
                        return UNO_APPLICATION.Properties.Resources.blue_reverse;
                    else
                        return UNO_APPLICATION.Properties.Resources.red_back;

                }
                else if (card.color == "yellow")
                {
                    if (card.action == "skip")
                        return UNO_APPLICATION.Properties.Resources.yellow_skip;
                    else if (card.action == "drawtwo")
                        return UNO_APPLICATION.Properties.Resources.yellow_draw2;
                    else if (card.action == "reverse")
                        return UNO_APPLICATION.Properties.Resources.yellow_reverse;
                    else
                        return UNO_APPLICATION.Properties.Resources.red_back;

                }
                else if (card.color == "red")
                {
                    if (card.action == "skip")
                        return UNO_APPLICATION.Properties.Resources.red_skip;
                    else if (card.action == "drawtwo")
                        return UNO_APPLICATION.Properties.Resources.red_draw2;
                    else if (card.action == "reverse")
                        return UNO_APPLICATION.Properties.Resources.red_reverse;
                    else
                        return UNO_APPLICATION.Properties.Resources.red_back;
                }
                else
                    return UNO_APPLICATION.Properties.Resources.red_back;




            }
            else if (card.type == "wild")
            {
                if (card.color == "blue")
                    return UNO_APPLICATION.Properties.Resources.wild_blue;
                else if (card.color == "green")
                    return UNO_APPLICATION.Properties.Resources.wild_green;
                else if (card.color == "yellow")
                    return UNO_APPLICATION.Properties.Resources.wild_yellow;
                else if (card.color == "red")
                    return UNO_APPLICATION.Properties.Resources.wild_red;
                else
                return UNO_APPLICATION.Properties.Resources.wild;

            }
            else if (card.type == "wild4")
            {
                if (card.color == "blue")
                    return UNO_APPLICATION.Properties.Resources.wild_4_blue;
                else if (card.color == "green")
                    return UNO_APPLICATION.Properties.Resources.wild_4_green;
                else if (card.color == "yellow")
                    return UNO_APPLICATION.Properties.Resources.wild_4_yellow;
                else if (card.color == "red")
                    return UNO_APPLICATION.Properties.Resources.wild_4_red;
                else
                    return UNO_APPLICATION.Properties.Resources.wild_4;

            }
            else
                return UNO_APPLICATION.Properties.Resources.red_back;

        }


    }
    
}
