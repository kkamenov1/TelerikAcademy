using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngryFemaleGPS
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());

            int sumEven = 0;
            int sumOdd = 0;

            if (n == 0)
            {
                Console.WriteLine("straight 0");
            }
            else
            {
                while (n != 0)
                {
                    long digit = n % 10;
                    n = n / 10;
                    if (digit % 2 == 0)
                    {
                        sumEven += (int)digit;
                    }
                    else
                    {
                        sumOdd += (int)digit;
                    }
                }
                if (sumEven > sumOdd) Console.WriteLine("right {0}", sumEven);
                else if (sumEven < sumOdd) Console.WriteLine("left {0}", sumOdd);
                else if (sumEven == sumOdd) Console.WriteLine("straight {0}", sumEven);
            }
        }
    }
}
