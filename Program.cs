﻿using System;
using System.Collections.Generic;

namespace AllCardsOnDeck
{
    class Program
    {
        static void Main(string[] args)
        {
            var deckOfCards = new List<string>() { "Ace of Clubs", "2  of Clubs", "3  of Clubs", "4 of Clubs", "5 of Clubs", "6 of Clubs", "7 of Clubs", "8 of Clubs", "9 of Clubs", "10 of Clubs", "Jack of Clubs", "Queen of Clubs", "King of Clubs", "Ace of Spades", "2 of Spades", "3 of Spades", "4 of Spades", "5 of Spades", "6 of Spades", "7 of Spades", "8 of Spades", "9 of Spades", "10 of Spades", "Jack of Spades", "Queen of Spades", "King of Spades", "Ace of Hearts", "2 of Hearts", "3 of Hearts", "4 of Hearts", "5 of Hearts", "6 of Hearts", "7 of Hearts", "8 of Hearts", "9 of Hearts", "10 of Hearts", "Jack of Hearts", "Queen of Hearts", "King of Hearts", "Ace of Diamonds", "2 of Diamonds", "3 of Diamonds", "4 of Diamonds", "5 of Diamonds", "6 of Diamonds", "7 of Diamonds", "8 of Diamonds", "9 of Diamonds", "10 of Diamonds", "Jack of Diamonds", "Queen of Diamonds", "King of Diamonds" };
            var cardCount = deckOfCards.Count;
            for (var index = cardCount - 1; index >= 0; index--)
            {
                var nextUpCard = deckOfCards[index];

                var randomNumberGenerator = new Random();
                var randomNumber = randomNumberGenerator.Next(cardCount);

                deckOfCards.RemoveAt(index);
                deckOfCards.Insert(randomNumber, nextUpCard);
            }
            var playerHand1 = new List<string>();
            var playerHand2 = new List<string>();

            for (var index2 = 0; index2 < 4; index2++)
            {
                if (index2 % 2 == 0)
                {
                    playerHand1.Add(deckOfCards[index2]);
                }
                else
                {
                    playerHand2.Add(deckOfCards[index2]);
                }
            }
            Console.Write("Player 1 Hand: ");
            Console.Write(playerHand1[0] + ", ");
            Console.WriteLine(playerHand1[1]);
            Console.Write("Player 2 Hand: ");
            Console.Write(playerHand2[0] + ", ");
            Console.WriteLine(playerHand2[1]);
        }
    }
}
