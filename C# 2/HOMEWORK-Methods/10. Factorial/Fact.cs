using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

// Write a program to calculate n! for each n in the range [1..100].

namespace _10.Factorial
{
    class Fact
    {
        static int[] ArrayMult(int[] arr, int value)
        {
            BigInteger bi = new BigInteger();

            for (int i = 0; i < arr.Length; i++)
            {
                bi += arr[i] * (BigInteger)Math.Pow(10, arr.Length - i - 1);
            }

            bi *= value;

            var list = new List<int>();
            
            while (bi != 0)
            {
                list.Add((int)(bi % 10));
                bi /= 10;
            }

            int[] result = list.ToArray();
            Array.Reverse(result);
            return result;
        }
        
        
        static void Main(string[] args)
        {
            Console.Write("N = ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[] { 1 };

            for (int i = 1; i < n + 1; i++)
            {
                arr = ArrayMult(arr, i);
            }

            Console.Write("N! = ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);
            }
            Console.WriteLine();
        }
    }
}
