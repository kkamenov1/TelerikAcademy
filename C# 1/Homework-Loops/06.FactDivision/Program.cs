using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _06.FactDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter value of N > 1");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter value of K<n<100");
            int k = int.Parse(Console.ReadLine());

            BigInteger result = 1;
            if (1 < k && n > k && n < 100)
            {
                for (int i = k + 1; i <= n; i++)
                {
                    result *= i;
                }
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
            Console.WriteLine("N!/!K = {0}", result);
        }
    }
}
