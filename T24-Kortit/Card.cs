using System;
using System.Collections.Generic;
using System.Text;

namespace T24_Kortit
{
    class Card
    {
        public string Value { get; set; }
        public string Suit { get; set; }

        public Card(string value, string suit)
        {
            Value = value;
            Suit = suit;
        }
    }
}
