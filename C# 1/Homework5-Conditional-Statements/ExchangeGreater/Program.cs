/*Problem 1. Exchange If Greater

Write an if-statement that takes two double variables a and b and exchanges their values if the first one is greater than the second one. As a result print the values a and b, separated by a space. */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeGreater
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double temp;

            if (a > b)
            {
                temp = a;
                a = b;
                b = temp;
                Console.WriteLine("{0} {1}", a, b);
            }
            else Console.WriteLine("{0} {1}", a, b);
        }
    }
}
