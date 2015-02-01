using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.DecimalToBinaryNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer number :");
            long dec = long.Parse(Console.ReadLine());
            long remainder;
            StringBuilder binary = new StringBuilder();

            while (dec > 0)
            {
                int index = 0;
                remainder = dec % 2;
                binary.Insert(index, remainder);

                dec /= 2;
                index++;
            }
            Console.WriteLine(binary);
        }
    }
}
