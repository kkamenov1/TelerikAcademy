using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace PingPongGame
{
    class Program
    {
        static int ballPositionX = 0;
        static int ballPositionY = 0;
        static int firstPlayerPosition = 0;
        static int secondPlayerPosition = 0;
        static int firstPlayerPadSize = 4;
        static int secondPlayerPadSize = 4;
        static int firstPlayerResult = 0;
        static int secondPlayerResult = 0;
        static Random randomGenerator = new Random();
        static bool ballUp = true;
        static bool ballRight = true;

        static void Main(string[] args)
        {
            ResizeWindow();
            SetInitialPositions();
            while(true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo userInput = Console.ReadKey();
                    if (userInput.Key == ConsoleKey.UpArrow)
                    {
                        MoveFirstPlayerUp();
                    }
                    if (userInput.Key == ConsoleKey.DownArrow)
                    {
                        MoveFirstPlayerDown();
                    }
                }
                
                Console.Clear();
                DrawFirstPlayer();
                DrawSecondPlayer();
                DrawBall();
                PrintResult();
                SecondPlayerAIMove();
                MoveBall();
                Thread.Sleep(65);
                
            }
        }

        static void Print(int x, int y, char c)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(c);
        }
        static void ResizeWindow()
        {
            Console.BufferHeight = Console.WindowHeight;
            Console.BufferWidth = Console.WindowWidth = 50;
        }
        static void DrawFirstPlayer()
        {
            for (int y = firstPlayerPosition; y < firstPlayerPosition + firstPlayerPadSize; y++)
			{
                Print(0, y, '*');
			}
        }
        static void DrawSecondPlayer()
        {
            for (int y = secondPlayerPosition; y < secondPlayerPosition + secondPlayerPadSize; y++)
            {
                Print(Console.WindowWidth - 1, y, '*');

            }
        }
        
        static void PrintResult()
        {
            Console.SetCursorPosition(Console.WindowWidth / 2 - 1, 0);
            Console.WriteLine("{0} - {1}", firstPlayerResult, secondPlayerResult);
        }

        static void DrawBall()
        {
            Print(ballPositionX, ballPositionY, '@');
        }
        static void SetInitialPositions()
        {
            firstPlayerPosition = Console.WindowHeight / 2 - firstPlayerPadSize / 2;
            secondPlayerPosition = Console.WindowHeight / 2 - secondPlayerPadSize / 2;
            ballPositionX = Console.WindowWidth / 2;
            ballPositionY = Console.WindowHeight / 2;
        }

        static void MoveFirstPlayerUp()
        {
            if(firstPlayerPosition > 0)
                firstPlayerPosition--;
        }

        static void MoveFirstPlayerDown()
        {
            if(firstPlayerPosition < Console.WindowHeight - firstPlayerPadSize) firstPlayerPosition++;
        }

        static void MoveSecondPlayerUp()
        {
            if (secondPlayerPosition > 0)
                secondPlayerPosition--;
        }

        static void MoveSecondPlayerDown()
        {
            if (secondPlayerPosition < Console.WindowHeight - secondPlayerPadSize) secondPlayerPosition++;
        }

        static void SecondPlayerAIMove()
        {
           int number = randomGenerator.Next(1, 101);
           // if (number == 0) MoveSecondPlayerDown();
            //else MoveSecondPlayerUp();
           if (number <= 70)
           {
               if (ballUp == true) MoveSecondPlayerUp();
               else MoveSecondPlayerDown();
           }
        }

        static void MoveBall()
        {
            if (ballPositionY == 0)
            {
                ballUp = false;
            }
            
            if(ballPositionY == Console.WindowHeight - 1)
            {
                ballUp = true;
            }
            
            if(ballPositionX == Console.WindowWidth - 1)
            {
                ballPositionX = Console.WindowWidth / 2;
                ballPositionY = Console.WindowHeight / 2;
                ballRight = false;
                firstPlayerResult++;
                Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2);
                Console.WriteLine("First Player WIN$!");
                Console.ReadKey();
            }

            if(ballPositionX == 0)
            {
                ballPositionX = Console.WindowWidth / 2;
                ballPositionY = Console.WindowHeight / 2;
                ballRight = true;
                secondPlayerResult++;
                Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2);
                Console.WriteLine("Second Player WIN$!");
                Console.ReadKey();
            }

            if(ballPositionX < 2)
            {
                if (ballPositionY >= firstPlayerPosition && ballPositionY < firstPlayerPosition + firstPlayerPadSize) ballRight = true;
            }

            if(ballPositionX >= Console.WindowWidth - 3)
            {
                if (ballPositionY >= secondPlayerPosition && ballPositionY < secondPlayerPosition + secondPlayerPadSize) ballRight = false;
            }

            if (ballUp)
            {
                ballPositionY--;
            }
            else ballPositionY++;

            if (ballRight)
            {
                ballPositionX++;
            }
            else ballPositionX--;

        }
    }
}
