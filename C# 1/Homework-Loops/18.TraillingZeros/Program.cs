using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.TraillingZeros
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int n = int.Parse(Console.ReadLine());

            int counter = 0;
            int divider = 5;
            while (n / divider >= 1)
            {
                counter += n / divider;
                divider *= 5;
            }
            Console.WriteLine("{0}! has {1} trailing zeros"
                                , n, counter);
        }
    }
}
