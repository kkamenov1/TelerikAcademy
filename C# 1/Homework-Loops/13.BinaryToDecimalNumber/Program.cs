using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.BinaryToDecimalNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a binary integer number :");
            string binary = Console.ReadLine();

            long number = 0;
            int power = 1;
            for (int i = binary.Length - 1; i >= 0; i--)
            {
                int sign = binary[i] - 48;
                if (sign == 1)
                {
                    number += sign * power;
                }
                power *= 2;
            }
            Console.WriteLine(number);
        }
    }
}
