using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace T24_Kortit
{
    class CardDeck
    {
        public List<Card> Cards { get; set; }

        public CardDeck(List<Card> cards)
        {
            Cards = cards;
        }


        public void Shuffle()
        {
            Cards = Cards.OrderBy(i => Guid.NewGuid()).ToList();
        }

    }
}
