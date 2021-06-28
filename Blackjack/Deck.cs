using System;
using System.Collections.Generic;
using Telegrambot1;

namespace Sidebot
{
    public class Deck
    {
        public List<Card> cards = new List<Card>();



        public void PrintDeck()
        {
            foreach (Card card in this.cards)
            {
                Console.WriteLine($"{card.Name}");
            }
        }

        void FillDeck()
            {
                for (int i = 0; i < 52; i++)
                {
                    Card.Suits suit = (Card.Suits)Math.Floor((decimal)i / 13);
                    //Adds 2 to the value, because cards start at 2
                    int val = i % 13 + 2;
                    cards.Add(new Card(val, suit));
                }
            }
        //Constructor that instantiates the deck, populates it with cards, then shuffles them.
        public Deck()
        {
            FillDeck();
            cards.Shuffle<Card>();
        }

        public Card PickOneCard()
        {
            Card firstCard = cards[0];
            cards.RemoveAt(0);
            Console.WriteLine($"{firstCard.Name}");
            return firstCard;
        }



    }
}