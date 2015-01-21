using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersInIntervalDividableByGivenNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input start of the interval: ");
            int start = int.Parse(Console.ReadLine());
            Console.Write("Input end of the interval: ");
            int end = int.Parse(Console.ReadLine());
            Console.Write("Input the divisor: ");
            int p = int.Parse(Console.ReadLine());

            for (int i = start; i <= end; i++)
            {
                if (i % p == 0) Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
