using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersNotDivisibleBy3And7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number for N:");
            int counter = int.Parse(Console.ReadLine());

            for (int i = 1; i <= counter; i++)
            {
                if (i % 3 != 0 && i % 7 != 0)
                {
                    Console.Write("{0} ", i);
                }
            }
        }
    }
}
