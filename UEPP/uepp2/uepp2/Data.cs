using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uepp2
{
    class Data
    {
        List<Card> cards = new List<Card> { new Card("Joker"),
            new Card("Twee"), new Card("Drie"), new Card("Vier") };

        private List<Card> deck = new List<Card>();
        private List<string> deckCardNames = new List<string>();

        public List<Card> GetDeck()
        {
            return deck;
        }

        public List<string> GetDeckCardNames()
        {
            List<string> cardNameList = new List<string>();

            foreach (Card item in GetDeck())
            {
                cardNameList.Add(item.GetName());
            }
            return cardNameList;
        }

        public void AddDeck(int amountOfDecks)
        {
            foreach(Card c in cards)
            {
                deck.Add(c);
            }
        }

        private int GetRandomNumber(Random random, int startNum, int endNum)
        {
            return random.Next(startNum, endNum); // van startnum TOT endnum
        }

        private List<Card> SwapCards(List<Card> deck, int firstNumber, int secondNumber)
        {
            Card c = deck[firstNumber];
            deck[firstNumber] = deck[secondNumber];
            deck[secondNumber] = c;

            return deck;
        }

        public List<Card> ShuffleCards(List<Card> deck)
        {
            Random random = new Random();

            for (int i = 0; i < 1000; i++)
            {
                int firstNumber = GetRandomNumber(random, 0, deck.Count);
                int secondNumber = GetRandomNumber(random, 0, deck.Count);

                while (firstNumber == secondNumber)
                {
                    secondNumber = GetRandomNumber(random, 0, deck.Count);
                }

                SwapCards(deck, firstNumber, secondNumber);
            }

            return deck;
        }

    }
}
