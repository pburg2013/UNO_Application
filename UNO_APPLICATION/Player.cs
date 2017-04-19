using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNO_APPLICATION
{
    public class Player
    {
        public IList<Card> hand = new List<Card>();//creating an emtpy hand
                                                   //  public bool turn; // used to check if it is the person's turn
        public int num_cards; //used to see how many cards the player has
        public string initials; // used to save the name of the player for the high scores
        //constructor for player class
        //Player will have an empty hand, set num_cards = 0
        //If the Player is computer then set initials to **
        public Player(string initials = "**")
        {
            this.initials = initials;
            num_cards = 0;
        }
        public void draw_newcard(Card newcard)
        {
            //Draw a card from the draw pile
            hand.Add(newcard);
            num_cards++;

        }
        public void remove_card(Card card_to_remove)
        {
            hand.Remove(card_to_remove);
            num_cards--;
        }
        public Card pick_card(Card top_card)
        {
            //based on top_card, pick 
        //IF computers turn go through hand and find matching card, if none find return invalid card
           
            if (top_card.type == "number")
            {
                foreach (Card n in hand)
                {
                    if (n.type == "number" && (n.num == top_card.num || n.color == top_card.color))
                    {
                        return n;
                    }
                    else if (n.type == "action" && n.color == top_card.color)
                    {
                        return n;
                    }
                }
            }
            else if (top_card.type == "action")
            {
                foreach (Card n in hand)
                {
                    if (n.type == "number" && n.color == top_card.color)
                    {
                        return n;
                    }
                    else if (n.type == "action" && (n.color == top_card.color || n.action == top_card.action))
                    {
                        return n;
                    }
                }

            }
            else if (top_card.type == "wild" || top_card.type == "wild4")
            {
                foreach (Card n in hand)
                {
                    if (n.type == "number" && n.color == top_card.color)
                    {
                        return n;
                    }
                    else if (n.type == "action" && n.color == top_card.color)
                    {
                        return n;
                    }
                }
                return new Card();
            }
            foreach (Card n in hand)
            {
                if (n.type == "wild" || n.type == "wild4")
                {
                    return n;
                }
            }//worst case computer has to draw
            Card invalidcard = new Card();
            return invalidcard;
        }


            

       
    }
}
