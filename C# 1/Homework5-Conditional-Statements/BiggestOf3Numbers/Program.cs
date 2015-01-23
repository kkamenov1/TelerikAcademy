/* Problem 5. The Biggest of 3 Numbers

Write a program that finds the biggest of three numbers. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiggestOf3Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            if (a > b && a > c) Console.WriteLine(a);
            else if (b > a && b > c) Console.WriteLine(b);
            else if (c > a && c > b) Console.WriteLine(c);
        }
    }
}
