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
            //Initialize dictionary and variables necessary to create deck of 52 cards.
            Dictionary<int, Card> cardDeck = new Dictionary<int, Card>();
            int key = 1;
            string[] suitArray = new string[] {"Clubs", "Diamonds", "Hearts", "Spades"};
            string[] valueArray = new string[] { "n/a", "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };
            int indexValue;

            //Create deck of 52 cards.
            foreach (string suit in suitArray)
            {
                for (indexValue = 1; indexValue <= 13; indexValue++)
                {
                    cardDeck.Add(key, new Card(suit, valueArray[indexValue]));
                    key++;
                }
            }
                       
            //Display the full deck of cards.
            Console.WriteLine("Here's the full deck of cards:\n");
            foreach (int Key in cardDeck.Keys)
            {
                cardDeck[Key].Display();
            }

            //Code found on stackoverflow...
            var r = new Random();
            // print random integer >= 0 and  < 100
            Console.WriteLine("\n" + r.Next(52));

            //Console.WriteLine("\nHere's the new deck:\n");
            //foreach (int Key in cardDeck.Keys)
            //{
            //    cardDeck[Key].Display();
            //}

            Console.ReadLine();
        }
    }
}
