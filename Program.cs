using System;
using System.Collections.Generic;

namespace NEWAllCardsOnDeck
{
    class Program
    {
        static void Main(string[] args)
        {
            var ranks = new List<string>() { "Ace", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };
            var suits = new List<string>() { "Heart", "Diamond", "Spade", "Club" };

            var deck = new List<string>();

            foreach (var suit in suits)
            {
                foreach (var rank in ranks)
                {
                    var newCard = $"The {rank} in {suit}";
                    deck.Add(newCard);
                }
            }

            // numberOfCards = length of our deck
            var numberOfCards = deck.Count;

            // for rightIndex from n - 1 down to 1 do:
            for (var rightIndex = deck.Count - 1; rightIndex >= 1; rightIndex--)
            {
                //  leftIndex = random integer that is greater than or equal to 0 and LESS than rightIndex
                var randomNumberGenerator = new Random();
                var leftIndex = randomNumberGenerator.Next(rightIndex);


                //   Now swap the values at rightIndex and leftIndex by doing this:
                //     leftCard = the value from deck[rightIndex]
                var leftCard = deck[leftIndex];

                //     rightChard = the value from deck[leftIndex]
                var rightCard = deck[rightIndex];

                //     deck[rightIndex] = rightChard
                deck[rightIndex] = leftCard;

                //     deck[leftIndex] = leftCard
                deck[leftIndex] = rightCard;
            }
            // get first card in deck and display
            var firstCard = deck[0];

            // get second card in deck and display
            var secondCard = deck[1];



        }
    }
}
