using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShuffleCards
{
    //Write a program to create a standard 52 card deck and then deal a random hand to a player. Once a card is dealt then it can't be used again.

    class Program
    {
        static void Main(string[] args)
        {
            //Lengthen console window.
            Console.SetWindowSize(80, 45);

            //Initialize list and variables necessary to create deck of 52 cards.
            List<Card> cardDeck = new List<Card>();
            string[] suitArray = new string[] { "Clubs", "Diamonds", "Hearts", "Spades" };
            string[] valueArray = new string[] { "n/a", "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };
            int indexValue;

            //Create deck of 52 cards.
            foreach (string suit in suitArray)
            {
                for (indexValue = 1; indexValue <= 13; indexValue++)
                {
                    cardDeck.Add(new Card(suit, valueArray[indexValue]));
                }
            }

            //Display the full deck of cards.
            Console.WriteLine("Here's the full deck of cards:\n");
            for (int i = 0; i < cardDeck.Count; i++)
            {
                cardDeck[i].Display();
            }


            cardDeck.RemoveAt(3);

            for (int i = 0; i < cardDeck.Count; i++)
            {
                cardDeck[i].Display();
            }

            Console.ReadLine();
        }
    }
}