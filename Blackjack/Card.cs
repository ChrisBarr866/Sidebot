using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using Telegrambot1;


namespace Sidebot
{
    public class Card
    {
        public enum Suits
        {
            Diamonds = 0,
            Hearts,
            Clubs,
            Spades
        }
        public Suits Suit { get; set; }
        public int Value { get; set; }

        public Card(int Value, Suits Suit)
        {
            this.Value = Value;
            this.Suit = Suit;
        }

        public string Name
        {
            get
            {
                return NamedValue + " of " + Suit.ToString();
            }
        }

        public string NamedValue
        {
            get
            {
                string name = Value switch
                {
                    14 => "Ace",
                    13 => "King",
                    12 => "Queen",
                    11 => "Jack",
                    _ => Value.ToString()
                };
                return name;
            }
        }
    }
}