using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.DecimalToHexadecimal
{
    class DecimalToHex
    {
        static string DecToHex(long decimalNumber)
        {
            string hex = string.Empty;

            while (decimalNumber > 0)
            {
                long digit = decimalNumber % 16;
                if (digit >= 0 && digit <= 9)
                {
                    hex = (char)(digit + '0') + hex;
                }
                else if (digit >= 10 && digit <= 15)
                {
                    hex = (char)(digit - 10 + 'A') + hex;
                }

                decimalNumber /= 16;
            }

            return hex;
        }
        
        static void Main(string[] args)
        {
            Console.Write("Enter decimal number: ");
            long number = long.Parse(Console.ReadLine());
            Console.WriteLine("Your number in hexadecimal format is " + DecToHex(number));
        }
    }
}
