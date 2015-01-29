using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardWars
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfTotalGames = int.Parse(Console.ReadLine());

            int playerOneGlobalScore = 0;
            int playerTwoGlobalScore = 0;
            bool xCardDrawnByPlayerOne = false;
            bool xCardDrawnByPlayerTwo = false;
            int gamesWonByPlayerOne = 0;
            int gamesWonByPlayerTwo = 0;
            const int numberOfCards = 3;

            for (int i = 0; i < numberOfTotalGames; i++)
            {
                int playerOneLocalScore = 0;
                int playerTwoLocalScore = 0;

                for (int j = 0; j < numberOfCards; j++)
                {
                    string card = Console.ReadLine();
                    switch (card)
                    {
                        case "A":
                            playerOneLocalScore += 1; break;
                        case "J":
                            playerOneLocalScore += 11; break;
                        case "Q":
                            playerOneLocalScore += 12; break;
                        case "K":
                            playerOneLocalScore += 13; break;
                        case "2":
                            playerOneLocalScore += 10; break;
                        case "3":
                            playerOneLocalScore += 9; break;
                        case "4":
                            playerOneLocalScore += 8; break;
                        case "5":
                            playerOneLocalScore += 7; break;
                        case "6":
                            playerOneLocalScore += 6; break;
                        case "7":
                            playerOneLocalScore += 5; break;
                        case "8":
                            playerOneLocalScore += 4; break;
                        case "9":
                            playerOneLocalScore += 3; break;
                        case "10":
                            playerOneLocalScore += 2; break;
                        case "X":
                            xCardDrawnByPlayerOne = true; break;
                        case "Y":
                            playerOneLocalScore -= 200; break;
                        case "Z":
                            playerOneLocalScore *= 2; break;
                    }
                }


                for (int j = 0; j < numberOfCards; j++)
                {
                    string card = Console.ReadLine();
                    switch (card)
                    {
                        case "A":
                            playerTwoLocalScore += 1; break;
                        case "J":
                            playerTwoLocalScore += 11; break;
                        case "Q":
                            playerTwoLocalScore += 12; break;
                        case "K":
                            playerTwoLocalScore += 13; break;
                        case "2":
                            playerTwoLocalScore += 10; break;
                        case "3":
                            playerTwoLocalScore += 9; break;
                        case "4":
                            playerTwoLocalScore += 8; break;
                        case "5":
                            playerTwoLocalScore += 7; break;
                        case "6":
                            playerTwoLocalScore += 6; break;
                        case "7":
                            playerTwoLocalScore += 5; break;
                        case "8":
                            playerTwoLocalScore += 4; break;
                        case "9":
                            playerTwoLocalScore += 3; break;
                        case "10":
                            playerTwoLocalScore += 2; break;
                        case "X":
                            xCardDrawnByPlayerTwo = true; break;
                        case "Y":
                            playerTwoLocalScore -= 200; break;
                        case "Z":
                            playerTwoLocalScore *= 2; break;
                    }
                }

                if (xCardDrawnByPlayerOne && xCardDrawnByPlayerTwo)
                {
                    playerOneGlobalScore += 50;
                    playerTwoGlobalScore += 50;

                    xCardDrawnByPlayerOne = false;
                    xCardDrawnByPlayerTwo = false;
                }
                else if (xCardDrawnByPlayerOne)
                {
                    Console.WriteLine("X card drawn! Player one wins the match!");
                    return;
                }
                else if (xCardDrawnByPlayerTwo)
                {
                    Console.WriteLine("X card drawn! Player two wins the match!");
                    return;
                }
                if (playerOneLocalScore > playerTwoLocalScore)
                {
                    playerOneGlobalScore += playerOneLocalScore;
                    gamesWonByPlayerOne++;
                }
                else if (playerOneLocalScore < playerTwoLocalScore)
                {
                    playerTwoGlobalScore += playerTwoLocalScore;
                    gamesWonByPlayerTwo++;
                }

            }
            if (playerOneGlobalScore > playerTwoGlobalScore)
            {
                Console.WriteLine("First player wins!");
                Console.WriteLine("Score: " + playerOneGlobalScore);
                Console.WriteLine("Games won: " + gamesWonByPlayerOne);
            }
            else if (playerOneGlobalScore < playerTwoGlobalScore)
            {
                Console.WriteLine("Second player wins!");
                Console.WriteLine("Score: " + playerTwoGlobalScore);
                Console.WriteLine("Games won: " + gamesWonByPlayerTwo);
            }
            else
            {
                Console.WriteLine("It's a tie!");
                Console.WriteLine("Score: " + playerOneGlobalScore);
            }

        }
    }
}
