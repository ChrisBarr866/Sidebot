using System;
using System.Collections.Generic;

namespace SideBot
{
    public static class ExtensionMethods
    {

        private static Random rng = new Random();
        public static void Shuffle<Card>(this IList<Card> cards)
        {
            int n = cards.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                Card value = cards[k];
                cards[k] = cards[n];
                cards[n] = value;
            }
        }
    }
}