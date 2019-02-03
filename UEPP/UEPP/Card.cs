using System;
using System.Collections.Generic;
using System.Text;

namespace UEPP
{
    public class Card
    {
        
        private string description;
        public enum Suit {Spades, Clubs, Hearts, Diamonds, None};
        private Suit suit;
        public enum Species {Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Jack, Lady, King, Ace, Joker};
        private Species species;

        public Card(string description, Suit suit, Species species)
        {
            this.description = description;
            this.suit = suit;
            this.species = species;
        }
    }
}
