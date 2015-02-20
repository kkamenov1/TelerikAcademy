using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Write a method GetMax() with two parameters that returns the larger of two integers.
// Write a program that reads 3 integers from the console and prints the largest of them using the method GetMax()

namespace _02.GetLargestNumber
{
    class LargestNumber
    {
        static int GetMax(int a, int b)
        {
            if (a > b)
                return a;
            else
                return b;
        }
        
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Enter third number: ");
            int c = int.Parse(Console.ReadLine());

            Console.Write("The greatest number is: ");
            Console.WriteLine(GetMax(GetMax(a, b), c));

        }
    }
}
