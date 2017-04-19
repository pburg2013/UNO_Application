using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNO_APPLICATION
{
    public class Draw_Pile
    {
        public List<Card> draw_pile = new List<Card>();
        public int num_cards; 
        public Draw_Pile() { num_cards = 0;  }

      
        public void add_deck()
        {
            //Add the entire deck
            //This is be called at the beginning of the game
            //creating the list of colors and actions
            IList<string> colors_of_deck = new List<string>() { "red", "blue", "green", "yellow" };
            IList<string> play_cards = new List<string>() { "drawtwo", "skip", "reverse" };

            //adding the uno cards
            foreach (string color in colors_of_deck)
            {
                //make the new cards for the number card
                for (int i = 0; i < 10; i++)
                {
                    draw_pile.Add(new num_card(i, color));
                    num_cards++;
                    if (i > 0)
                    {
                        draw_pile.Add(new num_card(i, color)); // adding again if not zero
                        num_cards++;
                    }
                }//make the play cards
                foreach (string action in play_cards)
                {
                    draw_pile.Add(new play_card(color, action));

                    draw_pile.Add(new play_card(color, action));
                    num_cards += 2;
                }
            }
            int k = 0;
            //adding 4 draw 4 wilds, and 4 regular wilds
            while (k < 4)
            {
                draw_pile.Add(new wild_card(true));
                num_cards++;
                draw_pile.Add(new wild_card(false));
                num_cards++;
                k++;
            }



        }

        public void add_card(Card newcard)
        {
            draw_pile.Add(newcard);
            num_cards++;
        }

        public void shuffle_deck()
        {
            draw_pile = Shuffle(draw_pile);

        }
        public Card draw_card()
        {
            //save/delete from list/ and return that card
            Card newcard = draw_pile[0];
            draw_pile.RemoveAt(0);
            num_cards--;
            return newcard;
        }
        public List<Card> Shuffle(List<Card> deck)
        {
            List<Card> Shuffeled = new List<Card>();
            int count = deck.Count;
            int selection = 0;
            Random rand = new Random();
            for (int i = 0; i < count; i++)
            {
                selection = rand.Next(deck.Count - 1);
                Shuffeled.Add(deck[selection]);
                deck.RemoveAt(selection);
            }
            return Shuffeled;
        }

    }

}
