﻿/* Problem 2. Bonus Score

Write a program that applies bonus score to given score in the range [1…9] by the following rules:
If the score is between 1 and 3, the program multiplies it by 10.
If the score is between 4 and 6, the program multiplies it by 100.
If the score is between 7 and 9, the program multiplies it by 1000.
If the score is 0 or more than 9, the program prints “invalid score”. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusScore
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if (n >= 1 && n <= 3)
            {
                n *= 10;
                Console.WriteLine(n);
            }
            else if (n >= 4 && n <= 6)
            {
                n *= 100;
                Console.WriteLine(n);
            }
            else if (n >= 7 && n <= 9)
            {
                n *= 1000;
                Console.WriteLine(n);
            }
            else Console.WriteLine("invalid score!");
        }
    }
}
