using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.BinaryToHexadecimal
{
    class Program
    {
        static long BinToDec(string binaryNumber)
        {
            long decimalNumber = 0;

            for (int i = 0; i < binaryNumber.Length; i++)
            {
                int digit = binaryNumber[i] - '0';
                int position = binaryNumber.Length - i - 1;
                decimalNumber += digit * (long)Math.Pow(2, position);
            }

            return decimalNumber;
        }

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

        static string BinToHex(string binNumber)
        {
            string hex = string.Empty;
            long decimalNumber = BinToDec(binNumber);
            return hex = DecToHex(decimalNumber);
        }

        static void Main(string[] args)
        {
            Console.Write("Enter number in binary format: ");
            string binNumber = Console.ReadLine();
            Console.WriteLine("Your number in hexadecimal format is " + BinToHex(binNumber));
        }
    }
}
