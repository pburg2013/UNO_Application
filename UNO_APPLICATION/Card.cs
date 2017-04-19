using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNO_APPLICATION
{
    public class Card
    {
        public int value;
        //every card will have an button that is set to invisible once created
        public string type; // useful to differentiate between card types
        public virtual string color { get; set; }
        public virtual int num { get; set; }
        public virtual string action { get; set; }
        public virtual bool drawFour { get; set; }
        public Card()
        {
            type = "invalid";
            value = 0;
            color = "";
        }
        public virtual string Output()
        {
            return this.type + " " + this.color;
            
        }
    }

    public class num_card : Card
    {
        //cards that have numbers and colors
        public override int num { get; set; }
        public override string color { get; set; }
        public num_card(int num, string color)
        { //setting the properties of the number card
            this.num = num;
            this.color = color;
            base.value = num;
            base.type = "number";
        }
        public override string Output()
        {
            return this.num + " " +this.color; 
        }

        
    }
    public class play_card : Card
    {//skip, draw2, reverse cards
        public override string color { get; set; }
        public override string action { get; set; }
        public play_card ( string color, string action)
        {
            this.color = color;
            this.action = action;
            base.value = 20;//based on rules from wikipedia
            base.type = "action";
        }
        public override string Output()
        {
            return this.action + " " + this.color;
        }
    }
    public class wild_card : Card
    {
        public override bool drawFour { get; set; }
        public wild_card ( bool drawFour)
        {//setting the wild card to draw four based on constructor
            this.drawFour = drawFour ? true : false;
            base.type = drawFour ? "wild4" : "wild";
            base.value = 50;
        }
        
    }

    
}
