using System;

public class Card
{
	public Card()
	{
        public int value_num { get; set; }// this will be used to get the score

        public virtual void Print_Value()
        {
            Console.WriteLine("Value: " + value_num);
        }


	}
}
