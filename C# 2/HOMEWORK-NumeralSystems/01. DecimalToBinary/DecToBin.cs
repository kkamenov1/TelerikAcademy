using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.DecimalToBinary
{
    class DecToBin
    {
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
        
        static void Main(string[] args)
        {
            Console.Write("Enter decimal number: ");
            long number = long.Parse(Console.ReadLine());
            Console.WriteLine("Number in binary: " + DecimalToBinary(number));
        }
    }
}
