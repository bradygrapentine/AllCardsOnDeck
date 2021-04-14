using System;
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

            for (var index2 = 0; index2 < deckOfCards.Count; index2++)
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
            // Console.Write("Player 1 Hand: ");
            // Console.Write(playerHand1[0] + ", ");
            // Console.WriteLine(playerHand1[1]);
            // Console.Write("Player 2 Hand: ");
            // Console.Write(playerHand2[0] + ", ");
            // Console.WriteLine(playerHand2[1]);
            var playerHand1Conv = new List<int>();
            var playerHand2Conv = new List<int>();
            foreach (var card in playerHand1)
            {
                switch (card)
                {
                    case "Ace of Clubs":
                    case "Ace of Spades":
                    case "Ace of Hearts":
                    case "Ace of Diamonds":
                        playerHand1Conv.Add(1);
                        break;
                    case "2 of Clubs":
                    case "2 of Spades":
                    case "2 of Hearts":
                    case "2 of Diamonds":
                        playerHand1Conv.Add(2);
                        break;
                    case "3 of Clubs":
                    case "3 of Spades":
                    case "3 of Hearts":
                    case "3 of Diamonds":
                        playerHand1Conv.Add(3);
                        break;
                    case "4 of Clubs":
                    case "4 of Spades":
                    case "4 of Hearts":
                    case "4 of Diamonds":
                        playerHand1Conv.Add(4);
                        break;
                    case "5 of Clubs":
                    case "5 of Spades":
                    case "5 of Hearts":
                    case "5 of Diamonds":
                        playerHand1Conv.Add(5);
                        break;
                    case "6 of Clubs":
                    case "6 of Spades":
                    case "6 of Hearts":
                    case "6 of Diamonds":
                        playerHand1Conv.Add(6);
                        break;
                    case "7 of Clubs":
                    case "7 of Spades":
                    case "7 of Hearts":
                    case "7 of Diamonds":
                        playerHand1Conv.Add(7);
                        break;
                    case "8 of Clubs":
                    case "8 of Spades":
                    case "8 of Hearts":
                    case "8 of Diamonds":
                        playerHand1Conv.Add(8);
                        break;
                    case "9 of Clubs":
                    case "9 of Spades":
                    case "9 of Hearts":
                    case "9 of Diamonds":
                        playerHand1Conv.Add(9);
                        break;
                    case "10 of Clubs":
                    case "10 of Spades":
                    case "10 of Hearts":
                    case "10 of Diamonds":
                        playerHand1Conv.Add(10);
                        break;
                    case "Jack of Clubs":
                    case "Jack of Spades":
                    case "Jack of Hearts":
                    case "Jack of Diamonds":
                        playerHand1Conv.Add(11);
                        break;
                    case "Queen of Clubs":
                    case "Queen of Spades":
                    case "Queen of Hearts":
                    case "Queen of Diamonds":
                        playerHand1Conv.Add(12);
                        break;
                    default:
                        playerHand1Conv.Add(13);
                        break;
                }
            }
            foreach (var card in playerHand2)
            {
                switch (card)
                {
                    case "Ace of Clubs":
                    case "Ace of Spades":
                    case "Ace of Hearts":
                    case "Ace of Diamonds":
                        playerHand2Conv.Add(14);
                        break;
                    case "2 of Clubs":
                    case "2 of Spades":
                    case "2 of Hearts":
                    case "2 of Diamonds":
                        playerHand2Conv.Add(2);
                        break;
                    case "3 of Clubs":
                    case "3 of Spades":
                    case "3 of Hearts":
                    case "3 of Diamonds":
                        playerHand2Conv.Add(3);
                        break;
                    case "4 of Clubs":
                    case "4 of Spades":
                    case "4 of Hearts":
                    case "4 of Diamonds":
                        playerHand2Conv.Add(4);
                        break;
                    case "5 of Clubs":
                    case "5 of Spades":
                    case "5 of Hearts":
                    case "5 of Diamonds":
                        playerHand2Conv.Add(5);
                        break;
                    case "6 of Clubs":
                    case "6 of Spades":
                    case "6 of Hearts":
                    case "6 of Diamonds":
                        playerHand2Conv.Add(6);
                        break;
                    case "7 of Clubs":
                    case "7 of Spades":
                    case "7 of Hearts":
                    case "7 of Diamonds":
                        playerHand2Conv.Add(7);
                        break;
                    case "8 of Clubs":
                    case "8 of Spades":
                    case "8 of Hearts":
                    case "8 of Diamonds":
                        playerHand2Conv.Add(8);
                        break;
                    case "9 of Clubs":
                    case "9 of Spades":
                    case "9 of Hearts":
                    case "9 of Diamonds":
                        playerHand2Conv.Add(9);
                        break;
                    case "10 of Clubs":
                    case "10 of Spades":
                    case "10 of Hearts":
                    case "10 of Diamonds":
                        playerHand2Conv.Add(10);
                        break;
                    case "Jack of Clubs":
                    case "Jack of Spades":
                    case "Jack of Hearts":
                    case "Jack of Diamonds":
                        playerHand2Conv.Add(11);
                        break;
                    case "Queen of Clubs":
                    case "Queen of Spades":
                    case "Queen of Hearts":
                    case "Queen of Diamonds":
                        playerHand2Conv.Add(12);
                        break;
                    default:
                        playerHand2Conv.Add(13);
                        break;
                }
                var player1Wins = new List<int>();
                var player2Wins = new List<int>();
                for (var index3 = 0; index3 < playerHand1Conv.Count; index3++)
                {
                    if (playerHand1Conv[index3] > playerHand2Conv[index3])
                    {
                        playerHand2Conv.RemoveAt(index3);
                        playerHand1Conv.RemoveAt(index3);
                        player1Wins.Add(playerHand1Conv[index3]);
                        player1Wins.Add(playerHand2Conv[index3]);

                    }
                    else if (playerHand2Conv[index3] > playerHand1Conv[index3])
                    {
                        playerHand1Conv.RemoveAt(index3);
                        playerHand2Conv.RemoveAt(index3);
                        player2Wins.Add(playerHand2Conv[index3]);
                        player2Wins.Add(playerHand1Conv[index3]);
                    }
                    else if (playerHand1Conv[index3] == playerHand2Conv[index3])
                    {
                        if (playerHand1Conv[index3 + 4] > playerHand2Conv[index3 + 4])
                        {
                            playerHand1Conv.RemoveAt(index3);
                            playerHand1Conv.RemoveAt(index3 + 1);
                            playerHand1Conv.RemoveAt(index3 + 2);
                            playerHand1Conv.RemoveAt(index3 + 3);
                            playerHand1Conv.RemoveAt(index3 + 4);
                            playerHand2Conv.RemoveAt(index3);
                            playerHand2Conv.RemoveAt(index3 + 1);
                            playerHand2Conv.RemoveAt(index3 + 2);
                            playerHand2Conv.RemoveAt(index3 + 3);
                            playerHand2Conv.RemoveAt(index3 + 4);
                            player1Wins.Add(playerHand2Conv[index3]);
                            player1Wins.Add(playerHand1Conv[index3]);
                            player1Wins.Add(playerHand2Conv[index3 + 1]);
                            player1Wins.Add(playerHand1Conv[index3 + 1]);
                            player1Wins.Add(playerHand2Conv[index3 + 2]);
                            player1Wins.Add(playerHand1Conv[index3 + 2]);
                            player1Wins.Add(playerHand2Conv[index3 + 3]);
                            player1Wins.Add(playerHand1Conv[index3 + 3]);
                            player1Wins.Add(playerHand2Conv[index3 + 4]);
                            player1Wins.Add(playerHand1Conv[index3 + 4]);
                        }
                        else if (playerHand1Conv[index3 + 4] < playerHand2Conv[index3 + 4])
                        {
                            playerHand1Conv.RemoveAt(index3);
                            playerHand1Conv.RemoveAt(index3 + 1);
                            playerHand1Conv.RemoveAt(index3 + 2);
                            playerHand1Conv.RemoveAt(index3 + 3);
                            playerHand1Conv.RemoveAt(index3 + 4);
                            playerHand2Conv.RemoveAt(index3);
                            playerHand2Conv.RemoveAt(index3 + 1);
                            playerHand2Conv.RemoveAt(index3 + 2);
                            playerHand2Conv.RemoveAt(index3 + 3);
                            playerHand2Conv.RemoveAt(index3 + 4);
                            player2Wins.Add(playerHand2Conv[index3]);
                            player2Wins.Add(playerHand1Conv[index3]);
                            player2Wins.Add(playerHand2Conv[index3 + 1]);
                            player2Wins.Add(playerHand1Conv[index3 + 1]);
                            player2Wins.Add(playerHand2Conv[index3 + 2]);
                            player2Wins.Add(playerHand1Conv[index3 + 2]);
                            player2Wins.Add(playerHand2Conv[index3 + 3]);
                            player2Wins.Add(playerHand1Conv[index3 + 3]);
                            player2Wins.Add(playerHand2Conv[index3 + 4]);
                            player2Wins.Add(playerHand1Conv[index3 + 4]);
                        }
                        else if (playerHand1Conv[index3 + 4] == playerHand2Conv[index3 + 4])
                        {
                            if (playerHand1Conv[index3 + 3] > playerHand2Conv[index3 + 3])
                            {
                                playerHand1Conv.RemoveAt(index3);
                                playerHand1Conv.RemoveAt(index3 + 1);
                                playerHand1Conv.RemoveAt(index3 + 2);
                                playerHand1Conv.RemoveAt(index3 + 3);
                                playerHand1Conv.RemoveAt(index3 + 4);
                                playerHand2Conv.RemoveAt(index3);
                                playerHand2Conv.RemoveAt(index3 + 1);
                                playerHand2Conv.RemoveAt(index3 + 2);
                                playerHand2Conv.RemoveAt(index3 + 3);
                                playerHand2Conv.RemoveAt(index3 + 4);
                                player1Wins.Add(playerHand2Conv[index3]);
                                player1Wins.Add(playerHand1Conv[index3]);
                                player1Wins.Add(playerHand2Conv[index3 + 1]);
                                player1Wins.Add(playerHand1Conv[index3 + 1]);
                                player1Wins.Add(playerHand2Conv[index3 + 2]);
                                player1Wins.Add(playerHand1Conv[index3 + 2]);
                                player1Wins.Add(playerHand2Conv[index3 + 3]);
                                player1Wins.Add(playerHand1Conv[index3 + 3]);
                                player1Wins.Add(playerHand2Conv[index3 + 4]);
                                player1Wins.Add(playerHand1Conv[index3 + 4]);
                            }
                            else if (playerHand1Conv[index3 + 3] < playerHand2Conv[index3 + 3])
                            {
                                playerHand1Conv.RemoveAt(index3);
                                playerHand1Conv.RemoveAt(index3 + 1);
                                playerHand1Conv.RemoveAt(index3 + 2);
                                playerHand1Conv.RemoveAt(index3 + 3);
                                playerHand1Conv.RemoveAt(index3 + 4);
                                playerHand2Conv.RemoveAt(index3);
                                playerHand2Conv.RemoveAt(index3 + 1);
                                playerHand2Conv.RemoveAt(index3 + 2);
                                playerHand2Conv.RemoveAt(index3 + 3);
                                playerHand2Conv.RemoveAt(index3 + 4);
                                player2Wins.Add(playerHand2Conv[index3]);
                                player2Wins.Add(playerHand1Conv[index3]);
                                player2Wins.Add(playerHand2Conv[index3 + 1]);
                                player2Wins.Add(playerHand1Conv[index3 + 1]);
                                player2Wins.Add(playerHand2Conv[index3 + 2]);
                                player2Wins.Add(playerHand1Conv[index3 + 2]);
                                player2Wins.Add(playerHand2Conv[index3 + 3]);
                                player2Wins.Add(playerHand1Conv[index3 + 3]);
                                player2Wins.Add(playerHand2Conv[index3 + 4]);
                                player2Wins.Add(playerHand1Conv[index3 + 4]);

                            }
                            else if (playerHand1Conv[index3 + 3] == playerHand2Conv[index3 + 3])
                            {
                                if (playerHand1Conv[index3 + 2] > playerHand2Conv[index3 + 2])
                                {
                                    playerHand1Conv.RemoveAt(index3);
                                    playerHand1Conv.RemoveAt(index3 + 1);
                                    playerHand1Conv.RemoveAt(index3 + 2);
                                    playerHand1Conv.RemoveAt(index3 + 3);
                                    playerHand1Conv.RemoveAt(index3 + 4);
                                    playerHand2Conv.RemoveAt(index3);
                                    playerHand2Conv.RemoveAt(index3 + 1);
                                    playerHand2Conv.RemoveAt(index3 + 2);
                                    playerHand2Conv.RemoveAt(index3 + 3);
                                    playerHand2Conv.RemoveAt(index3 + 4);
                                    player1Wins.Add(playerHand2Conv[index3]);
                                    player1Wins.Add(playerHand1Conv[index3]);
                                    player1Wins.Add(playerHand2Conv[index3 + 1]);
                                    player1Wins.Add(playerHand1Conv[index3 + 1]);
                                    player1Wins.Add(playerHand2Conv[index3 + 2]);
                                    player1Wins.Add(playerHand1Conv[index3 + 2]);
                                    player1Wins.Add(playerHand2Conv[index3 + 3]);
                                    player1Wins.Add(playerHand1Conv[index3 + 3]);
                                    player1Wins.Add(playerHand2Conv[index3 + 4]);
                                    player1Wins.Add(playerHand1Conv[index3 + 4]);
                                }
                                else if (playerHand1Conv[index3 + 2] < playerHand2Conv[index3 + 2])
                                {
                                    playerHand1Conv.RemoveAt(index3);
                                    playerHand1Conv.RemoveAt(index3 + 1);
                                    playerHand1Conv.RemoveAt(index3 + 2);
                                    playerHand1Conv.RemoveAt(index3 + 3);
                                    playerHand1Conv.RemoveAt(index3 + 4);
                                    playerHand2Conv.RemoveAt(index3);
                                    playerHand2Conv.RemoveAt(index3 + 1);
                                    playerHand2Conv.RemoveAt(index3 + 2);
                                    playerHand2Conv.RemoveAt(index3 + 3);
                                    playerHand2Conv.RemoveAt(index3 + 4);
                                    player2Wins.Add(playerHand2Conv[index3]);
                                    player2Wins.Add(playerHand1Conv[index3]);
                                    player2Wins.Add(playerHand2Conv[index3 + 1]);
                                    player2Wins.Add(playerHand1Conv[index3 + 1]);
                                    player2Wins.Add(playerHand2Conv[index3 + 2]);
                                    player2Wins.Add(playerHand1Conv[index3 + 2]);
                                    player2Wins.Add(playerHand2Conv[index3 + 3]);
                                    player2Wins.Add(playerHand1Conv[index3 + 3]);
                                    player2Wins.Add(playerHand2Conv[index3 + 4]);
                                    player2Wins.Add(playerHand1Conv[index3 + 4]);
                                }
                                else if (playerHand1Conv[index3 + 2] == playerHand2Conv[index3 + 2])
                                {
                                    if (playerHand1Conv[index3 + 1] > playerHand2Conv[index3 + 1])
                                    {
                                        playerHand1Conv.RemoveAt(index3);
                                        playerHand1Conv.RemoveAt(index3 + 1);
                                        playerHand1Conv.RemoveAt(index3 + 2);
                                        playerHand1Conv.RemoveAt(index3 + 3);
                                        playerHand1Conv.RemoveAt(index3 + 4);
                                        playerHand2Conv.RemoveAt(index3);
                                        playerHand2Conv.RemoveAt(index3 + 1);
                                        playerHand2Conv.RemoveAt(index3 + 2);
                                        playerHand2Conv.RemoveAt(index3 + 3);
                                        playerHand2Conv.RemoveAt(index3 + 4);
                                        player1Wins.Add(playerHand2Conv[index3]);
                                        player1Wins.Add(playerHand1Conv[index3]);
                                        player1Wins.Add(playerHand2Conv[index3 + 1]);
                                        player1Wins.Add(playerHand1Conv[index3 + 1]);
                                        player1Wins.Add(playerHand2Conv[index3 + 2]);
                                        player1Wins.Add(playerHand1Conv[index3 + 2]);
                                        player1Wins.Add(playerHand2Conv[index3 + 3]);
                                        player1Wins.Add(playerHand1Conv[index3 + 3]);
                                        player1Wins.Add(playerHand2Conv[index3 + 4]);
                                        player1Wins.Add(playerHand1Conv[index3 + 4]);
                                    }
                                    else if (playerHand1Conv[index3 + 1] < playerHand2Conv[index3 + 1])
                                    {
                                        playerHand1Conv.RemoveAt(index3);
                                        playerHand1Conv.RemoveAt(index3 + 1);
                                        playerHand1Conv.RemoveAt(index3 + 2);
                                        playerHand1Conv.RemoveAt(index3 + 3);
                                        playerHand1Conv.RemoveAt(index3 + 4);
                                        playerHand2Conv.RemoveAt(index3);
                                        playerHand2Conv.RemoveAt(index3 + 1);
                                        playerHand2Conv.RemoveAt(index3 + 2);
                                        playerHand2Conv.RemoveAt(index3 + 3);
                                        playerHand2Conv.RemoveAt(index3 + 4);
                                        player2Wins.Add(playerHand2Conv[index3]);
                                        player2Wins.Add(playerHand1Conv[index3]);
                                        player2Wins.Add(playerHand2Conv[index3 + 1]);
                                        player2Wins.Add(playerHand1Conv[index3 + 1]);
                                        player2Wins.Add(playerHand2Conv[index3 + 2]);
                                        player2Wins.Add(playerHand1Conv[index3 + 2]);
                                        player2Wins.Add(playerHand2Conv[index3 + 3]);
                                        player2Wins.Add(playerHand1Conv[index3 + 3]);
                                        player2Wins.Add(playerHand2Conv[index3 + 4]);
                                        player2Wins.Add(playerHand1Conv[index3 + 4]);
                                    }
                                    else
                                    {
                                        Console.WriteLine("WE ARE JUST GONNA CALL THIS ROUND A TIE.");
                                        playerHand1Conv.RemoveAt(index3);
                                        playerHand1Conv.RemoveAt(index3 + 1);
                                        playerHand1Conv.RemoveAt(index3 + 2);
                                        playerHand1Conv.RemoveAt(index3 + 3);
                                        playerHand1Conv.RemoveAt(index3 + 4);
                                        playerHand2Conv.RemoveAt(index3);
                                        playerHand2Conv.RemoveAt(index3 + 1);
                                        playerHand2Conv.RemoveAt(index3 + 2);
                                        playerHand2Conv.RemoveAt(index3 + 3);
                                        playerHand2Conv.RemoveAt(index3 + 4);
                                        continue;
                                    }
                                }
                            }
                        }
                        if (player1Wins.Count > player2Wins.Count)
                        {
                            Console.WriteLine("Player 1 Wins!");
                        }
                        else if (player1Wins.Count < player2Wins.Count)
                        {
                            Console.WriteLine("Player 2 Wins!");
                        }
                        else
                        {
                            Console.WriteLine("It's a tie.");
                        }
                    }
                }
            }
        }
    }
}
