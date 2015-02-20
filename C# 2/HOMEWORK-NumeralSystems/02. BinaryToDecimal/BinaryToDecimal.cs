using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.BinaryToDecimal
{
    class BinaryToDecimal
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
        
        static void Main(string[] args)
        {
            Console.Write("Enter number in binary format: ");
            string number = Console.ReadLine();
            Console.WriteLine("Your number in decimal format is " + BinToDec(number));
        }
    }
}
