using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.MatrixOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number [1-20]");
            int n = int.Parse(Console.ReadLine());

            if (n > 0 && n <= 20)
            {
                for (int row = 1; row <= n; row++)
                {
                    for (int coll = 0; coll < n; coll++)
                    {
                        Console.Write("{0,2} ", coll + row);
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("The number must be bigger than 0 and lesser than 21");
            }
        }
    }
}
