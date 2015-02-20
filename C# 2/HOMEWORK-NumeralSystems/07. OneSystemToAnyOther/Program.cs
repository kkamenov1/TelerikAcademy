using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.OneSystemToAnyOther
{
    class Program
    {
        static string DecimalToBase(long decimalNumber, int numeralSystem)
        {
            string result = string.Empty;
            while (decimalNumber > 0)
            {
                long digit = decimalNumber % numeralSystem;
                if (digit >= 0 && digit <= 9)
                {
                    result = (char)(digit + '0') + result;
                }
                else
                {
                    result = (char)(digit - 10 + 'A') + result;
                }
                decimalNumber /= numeralSystem;
            }
            return result;
        }

        static long BaseToDecimal(string number, int numberalSystem)
        {
            long decimalNumber = 0;
            for (int i = 0; i < number.Length; i++)
            {
                int digit = 0;
                if (number[i] >= '0' && number[i] <= '9')
                {
                    digit = number[i] - '0';
                }
                else
                {
                    digit = number[i] - 'A' + 10;
                }

                decimalNumber += digit * (long)Math.Pow(numberalSystem, number.Length - i - 1);
            }
            return decimalNumber;
        }

        static string BaseToBase(string number, int fromBase, int toBase)
        {
            return DecimalToBase(BaseToDecimal(number, fromBase), toBase);
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine(BaseToBase("1A", 16, 10));
        }
    }
}
