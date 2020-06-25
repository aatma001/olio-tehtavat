using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace T24_Kortit
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] cards = { "Ace", "One", "Two", "Three", "Four", "Five", "Six",
                                "Seven", "Eight", "Nine", "Ten", 
                                "Jack", "Queen", "King"};

            string[] suits = { "spades", "hearts", "diamonds", "clubs" };
            List<Card> cardlist = new List<Card>();

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 13; j++) 
                {
                    cardlist.Add(new Card(cards[j], suits[i]));
                }
            }
            CardDeck deck = new CardDeck(cardlist);

            ShowCards(deck.Cards);
            deck.Shuffle();

            Console.WriteLine();
            ShowCards(deck.Cards);
        }
        public static void ShowCards(List<Card> cards)
        { 
            foreach (Card item in cards)
            {
                Console.WriteLine(item.Value + " of " + item.Suit);
            }
        }
    }
}

