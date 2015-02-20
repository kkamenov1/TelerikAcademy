using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Write a method that adds two positive integer numbers represented as arrays of digits 
// (each array element arr[i] contains a digit; the last digit is kept in arr[0]).
// Each of the numbers that will be added could have up to 10 000 digits.
namespace _08.NumbersAsArray
{
    class NumbersAsArray
    {
        static byte[] Add(byte[] a, byte[] b)
        {
            if (a.Length > b.Length)
            {
                return Add(b, a);
            }
            PrintResult(a);
            PrintResult(b);

            byte[] result = new byte[b.Length + 1];
            int i = 0;
            int carry = 0;

            while (i < a.Length)
            {
                result[i] = (byte)(a[i] + b[i] + carry);
                carry = result[i] / 10;
                result[i] %= 10;
                i++;
            }

            while (i < b.Length && carry != 0)
            {
                result[i] = (byte)(b[i] + carry);
                carry = result[i] / 10;
                result[i] %= 10;
                i++;
            }

            while (i < b.Length)
            {
                result[i] = b[i];
                i++;
            }

            if (carry != 0)
            {
                result[i] = 1;
            }

            else
            {
                Array.Resize(ref result, result.Length - 1);
            }
            return result;
        }

        private static void PrintResult(byte[] a)
        {
            for (int i = a.Length - 1; i >= 0; i--)
            {
                Console.Write(a[i]);
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            PrintResult(Add(new byte[] { 3, 6, 1 }, new byte[] { 7, 2, 5 }));
            PrintResult(Add(new byte[] { 8, 9, 9 }, new byte[] { 1 }));
            PrintResult(Add(new byte[] { 1 }, new byte[] { 9, 9 }));   
        }
    }
}
