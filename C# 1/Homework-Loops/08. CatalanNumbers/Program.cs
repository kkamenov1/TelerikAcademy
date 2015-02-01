using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _08.CatalanNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Catalan number:");
            int n = int.Parse(Console.ReadLine());

            BigInteger divident = 1;
            BigInteger divider = 1;
            if (n > 0 && n < 100)
            {
                for (int i = 2 * n; i > n + 1; i--)
                {
                    divident *= i;
                }
                for (int i = 1; i <= n; i++)
                {
                    divider *= i;
                }
                BigInteger result = divident / divider;
                Console.WriteLine("The {0} Catalan number is: {1}", n, result);
            }
            else
            {
                Console.WriteLine("The number must be bigger than zero");
            }
        }
    }
}
