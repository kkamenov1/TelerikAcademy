using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrunkenNumbers
{
    class Program
    {
        static int mitkoBeers = 0;
        static int vladkoBeers = 0;

        static void CalculateBeers(int number)
        {
            string digits = number.ToString();
            for (int i = 0; i < digits.Length; i++)
            {
                if (i < digits.Length / 2)
                {
                    mitkoBeers += digits[i] - '0';
                }
                else
                    vladkoBeers += digits[i] - '0';
            }
            if (digits.Length % 2 != 0)
            {
                mitkoBeers += digits[digits.Length / 2] - '0';
            }
        }
        
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                CalculateBeers(int.Parse(Console.ReadLine()));
                if (mitkoBeers > vladkoBeers)
                {
                    Console.WriteLine("M {0}", mitkoBeers - vladkoBeers);
                }
                else if (mitkoBeers < vladkoBeers)
                {
                    Console.WriteLine("V {0}", vladkoBeers - mitkoBeers);
                }
                else { Console.WriteLine("No {0}", mitkoBeers + vladkoBeers);
                }
            }

        }
    }
}
