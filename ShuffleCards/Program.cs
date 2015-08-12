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
            //Lengthen the console window.
            Console.SetWindowSize(80, 58);

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
            Console.WriteLine("FULL DECK OF CARDS (WITHOUT THE JOKERS):");
            for (int i = 0; i < cardDeck.Count; i++)
            {
                cardDeck[i].Display();
            }
            
            //Prompt user to ask to be dealt a hand of cards.
            Console.Write("\nTO HAVE THE DECK SHUFFLED AND TO BE DEALT A HAND OF CARDS, PRESS <Enter>: ");
            Console.Read();

            //Initialize list for the new hand; these cards will first be removed from the original deck.
            List<Card> newHand = new List<Card>();
            
            
            //"Shuffle" the deck and deal 5 cards.
            //for (int j = 1; j <= 5; j++ )
            //    newHand.Add(Card[__]);

            //var rand = new Random();
            //var randomList = imagesEasy.OrderBy(x => rand.Next()).ToList();


            //cardDeck.RemoveAt(3);

            //for (int i = 0; i < cardDeck.Count; i++)
            //{
            //    cardDeck[i].Display();
            //}

            Console.ReadLine();
        }
    }
}