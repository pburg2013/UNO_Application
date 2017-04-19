using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNO_APPLICATION
{
    public class Discard_Pile
    {
        public Stack<Card> discard_pile = new Stack<Card>();
        //Top_card represented as top of stack
        public int num_cards;

        public Card get_topcard()
        {
            //return top of stack
            num_cards--;
            return discard_pile.Pop();
        }
        public void add_card(Card new_card)
        {
            discard_pile.Push(new_card);
            num_cards++;
        }
    }
}
