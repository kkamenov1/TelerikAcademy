/* Problem 7. Sort 3 Numbers with Nested Ifs

Write a program that enters 3 real numbers and prints them sorted in descending order.
Use nested if statements. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort3NumbersNestedIFs
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            if (a > b)
            {
                if (b > c) Console.WriteLine("{0} {1} {2}", a, b, c);
            }
            else if (a > c)
            {
                if (c < b) Console.WriteLine("{0} {1} {2}", b, a, c);
            }
            else Console.WriteLine("{0} {1} {2}", c, a, b);
        }
    }
}
