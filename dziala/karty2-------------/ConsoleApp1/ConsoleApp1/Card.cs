using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Card
    {
        public Suits Suit { get; set; }
        public Values Value { get; set; }
        public Card(Suits suit, Values value)
        {
            this.Suit = suit;
            this.Value = value;
        }
        public string Name
        {
            get { return Value.ToString() + " of " + Suit.ToString(); }
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
