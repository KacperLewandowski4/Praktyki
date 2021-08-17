using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Deck
    {
        private Card[] cards =
        {
            new Card(Suits.Spades, Values.Ace),
            new Card(Suits.Spades, Values.Two),
            new Card(Suits.Spades, Values.Three),
            new Card(Suits.Spades, Values.Four),
            new Card(Suits.Spades, Values.Five),
            new Card(Suits.Spades, Values.Six),
            new Card(Suits.Spades, Values.Seven),
            new Card(Suits.Spades, Values.Eight),
            new Card(Suits.Spades, Values.Nine),
            new Card(Suits.Spades, Values.Ten),
            new Card(Suits.Spades, Values.Jack),
            new Card(Suits.Spades, Values.Queen),
            new Card(Suits.Spades, Values.King),

            new Card(Suits.Hearts, Values.Ace),
            new Card(Suits.Hearts, Values.Two),
            new Card(Suits.Hearts, Values.Three),
            new Card(Suits.Hearts, Values.Four),
            new Card(Suits.Hearts, Values.Five),
            new Card(Suits.Hearts, Values.Six),
            new Card(Suits.Hearts, Values.Seven),
            new Card(Suits.Hearts, Values.Eight),
            new Card(Suits.Hearts, Values.Nine),
            new Card(Suits.Hearts, Values.Ten),
            new Card(Suits.Hearts, Values.Jack),
            new Card(Suits.Hearts, Values.Queen),
            new Card(Suits.Hearts, Values.King),

            new Card(Suits.Diamonds, Values.Ace),
            new Card(Suits.Diamonds, Values.Two),
            new Card(Suits.Diamonds, Values.Three),
            new Card(Suits.Diamonds, Values.Four),
            new Card(Suits.Diamonds, Values.Five),
            new Card(Suits.Diamonds, Values.Six),
            new Card(Suits.Diamonds, Values.Seven),
            new Card(Suits.Diamonds, Values.Eight),
            new Card(Suits.Diamonds, Values.Nine),
            new Card(Suits.Diamonds, Values.Ten),
            new Card(Suits.Diamonds, Values.Jack),
            new Card(Suits.Diamonds, Values.Queen),
            new Card(Suits.Diamonds, Values.King),

            new Card(Suits.Clubs, Values.Ace),
            new Card(Suits.Clubs, Values.Two),
            new Card(Suits.Clubs, Values.Three),
            new Card(Suits.Clubs, Values.Four),
            new Card(Suits.Clubs, Values.Five),
            new Card(Suits.Clubs, Values.Six),
            new Card(Suits.Clubs, Values.Seven),
            new Card(Suits.Clubs, Values.Eight),
            new Card(Suits.Clubs, Values.Nine),
            new Card(Suits.Clubs, Values.Ten),
            new Card(Suits.Clubs, Values.Jack),
            new Card(Suits.Clubs, Values.Queen),
            new Card(Suits.Clubs, Values.King),

        };
        public void PrintCards()
        {
            for (int i = 0; i < cards.Length; i++)
                Console.WriteLine(cards[i].Name);
        }
    }
}
