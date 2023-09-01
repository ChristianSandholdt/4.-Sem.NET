using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Opgave4_5.Card;

namespace Opgave4_5
{
    public class Card
    {
     
        public enum Number
        {
            TWO, THREE, FOUR, FIVE, SIX, SEVEN, EIGHT, NINE, TEN, JACK, QUEEN, KING, ACE
        }
        public enum Suit
        {
            HEARTS, DIAMONDS, CLUBS, SPADES
        }

        public Suit suit { get; set; }
        public Number number { get; set; }
        public Card(Suit suit, Number number)
        {
            this.suit = suit;
            this.number = number;
        }

        public delegate bool FilterCardDelegate(Card card);
        public override string ToString()
        {
            return number + " OF " + suit;
        }


        public class Cardgame
        {
            List<Card> cards = new List<Card>();

            public List<Card> filterCardGame(FilterCardDelegate filter)
            {
                List<Card> cardResult = new List<Card>();
                foreach (Card card in cards)
                {
                    if (filter(card))
                    {
                        cardResult.Add(card);
                    }
                }
                for (int i = 0; i < cardResult.Count(); i++)
                {
                    Console.WriteLine(cardResult[i]);
                }
                return cardResult;
            }

            public Cardgame(int x)
            {
                if (x == 0)
                {
                    cards = new List<Card>();
                    return;
                }
                cards = new List<Card>();

                for (int suitVal = 0; suitVal < 4; suitVal++)
                {
                    for (int rankVal = 0; rankVal < 13; rankVal++)
                    {
                        cards.Add(new Card((Suit)suitVal, (Number)rankVal));
                    }
                }
            }

            public void printGame()
            {
                foreach (Card card in cards)
                {
                    Console.WriteLine(card.ToString());
                }
            }


        }


    }
}
