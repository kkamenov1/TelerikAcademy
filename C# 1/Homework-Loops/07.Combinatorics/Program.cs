using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _07.Combinatorics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter value of N > 1");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter value of K<n<100");
        int k = int.Parse(Console.ReadLine());

        BigInteger fact1 = 1;
        BigInteger fact2 = 1;

        if (1 < k && n > k && n < 100)
        {
            for (int i = k + 1; i <= n; i++)
            {
                fact1 *= i;
            }
            for (int j = 1; j <= (n - k); j++)
            {
                fact2 *= j;
            }
        }
        else
        {
            Console.WriteLine("Invalid Input");
        }
        BigInteger result = fact1 / fact2;
        Console.WriteLine("N! / K!(N-K)! = {0}", result);
        }
    }
}
