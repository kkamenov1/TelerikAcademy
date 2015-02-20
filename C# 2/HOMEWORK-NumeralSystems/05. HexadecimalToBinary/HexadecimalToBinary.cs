using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.HexadecimalToBinary
{
    class HexadecimalToBinary
    {
        static long HexToDec(string hex)
        {
            long number = 0;
            for (int i = 0; i < hex.Length; i++)
            {
                int digit = 0;
                if (hex[i] >= '0' && hex[i] <= '9')
                {
                    digit = hex[i] - '0';

                }
                else if (hex[i] >= 'A' && hex[i] <= 'F')
                {
                    digit = hex[i] - 'A' + 10;
                }
                number += digit * (long)Math.Pow(16, hex.Length - i - 1);
            }

            return number;
        }

        static string DecimalToBinary(long decimalNumber)
        {
            string binaryNumber = string.Empty;

            while (decimalNumber > 0)
            {
                var digit = decimalNumber % 2;
                binaryNumber = digit + binaryNumber;
                decimalNumber /= 2;
            }

            return binaryNumber;
        }
        
        static string HexToBin(string hex)
        {
            string binNumber = string.Empty;
            long decimalNumber = HexToDec(hex);
            
            return binNumber = DecimalToBinary(decimalNumber);
        }
        
        static void Main(string[] args)
        {
            Console.Write("Enter number in hexadecimal format: ");
            string hex = Console.ReadLine();
            Console.WriteLine("Your number in binary format is " + HexToBin(hex));
        }
    }
}
