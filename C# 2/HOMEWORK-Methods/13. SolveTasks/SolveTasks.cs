using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Write a program that can solve these tasks:
// Reverses the digits of a number
// Calculates the average of a sequence of integers
// Solves a linear equation a * x + b = 0
// Create appropriate methods.
// Provide a simple text-based menu for the user to choose which task to solve.
// Validate the input data:
// The decimal number should be non-negative
// The sequence should not be empty
// a should not be equal to 0

namespace _13.SolveTasks
{
    class SolveTasks
    {
        static void ReverseNumber()
        {
            while (true)
            {
                Console.Write("Enter number: ");
                decimal n = decimal.Parse(Console.ReadLine());
                if (n > 0)
                {
                    decimal reversed = decimal.Parse(new string(n.ToString().Reverse().ToArray()));
                    Console.Write("Your reversed number is: " + reversed);
                    Console.WriteLine();
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input data!");
                    Environment.Exit(1);
                }
            }
        }

        static void Average()
        {
            while (true)
            {
                Console.Write("Enter size of the array: ");
                int n = int.Parse(Console.ReadLine());
                int[] arr = new int[n];
                if (n > 0)
                {
                    int sum = 0;
                    double average;
                    for (int i = 0; i < arr.Length; i++)
                    {
                        Console.Write("a[{0}] = ", i);
                        arr[i] = int.Parse(Console.ReadLine());
                    }

                    for (int i = 0; i < arr.Length; i++)
                    {
                        sum += arr[i];
                    }

                    average = (double) sum / n;
                    Console.WriteLine("The average from the sequence is: " + average);
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input data!");
                    Environment.Exit(1);
                }
            }
        }

        static void SolveLinearEquation()
        {
            while (true)
            {
                Console.Write("Enter A: ");
                int A = int.Parse(Console.ReadLine());
                if (A == 0)
                {
                    Console.WriteLine("A should not be equal to 0");
                    continue;
                }
                Console.Write("Enter B: ");
                int B = int.Parse(Console.ReadLine());
                double result;

                result = (double) -B / A;
                Console.WriteLine("The result of the equation is: " + result);
                break;
                
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Choose an option from the menu: ");
            Console.WriteLine("**************MENU**************");
            Console.WriteLine("1. Reverse the digits from a number.");
            Console.WriteLine("2. Calculates the average of a sequence of integers");
            Console.WriteLine("3. Solves a linear equation a * x + b = 0");
            Console.WriteLine("********************************");
            Console.Write("Your choice: ");
            int choice = int.Parse(Console.ReadLine());
            if (choice < 0 || choice > 3)
            {
                Console.WriteLine("Invalid choice number!");
                return;
            }
            switch(choice)
            {
                case 1: ReverseNumber(); break;
                case 2: Average(); break;
                case 3: SolveLinearEquation(); break;
            }
        }
    }
}
