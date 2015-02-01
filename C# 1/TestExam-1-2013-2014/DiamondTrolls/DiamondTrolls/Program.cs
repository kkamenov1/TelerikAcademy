using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiamondTrolls
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // input of N and clearing the console
            int n = int.Parse(Console.ReadLine());
            Console.Clear();


            // printing top line
            Console.Write(new string('.', (n + 1) / 2));
            Console.Write(new string('*', n));
            Console.WriteLine(new string('.', (n + 1) / 2));

            // printing upper without first line
            for (int i = 0; i < n / 2; i++)
            {
                Console.Write(new string('.', (n / 2) - i));
                Console.Write('*');
                Console.Write(new string('.', (n / 2) + i));
                Console.Write('*');
                Console.Write(new string('.', (n / 2) + i));
                Console.Write('*');
                Console.WriteLine(new string('.', (n / 2) - i));
            }

            // printing the mid of the diamond
            Console.WriteLine(new string('*', 2 * n + 1));

            // printing bottom side of the diamond without the last line

            for (int i = 0; i < n - 1; i++)
            {
                Console.Write(new string('.', i + 1));
                Console.Write('*');
                Console.Write(new string('.', n - 2 - i));
                Console.Write('*');
                Console.Write(new string('.', n - 2 - i));
                Console.Write('*');
                Console.WriteLine(new string('.', i + 1));
            }

            // printing the last line of the diamond

            Console.Write(new string('.', n));
            Console.Write('*');
            Console.WriteLine(new string('.', n));

        }
    }
}
