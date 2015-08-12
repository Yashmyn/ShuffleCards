using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShuffleCards
{
    class Card
    {
        public string cardSuit;
        public string cardValue;

        public Card() //the default constructor
        {

        }

        public Card(string _cardSuit, string _cardValue) //overloaded constructor
        {
            this.cardSuit = _cardSuit;
            this.cardValue = _cardValue;
        }

        public void Display()
        {
            Console.WriteLine("\t" + this.cardValue + " of " + this.cardSuit);
        }

        public void Deal()
        {

        }
    }
}