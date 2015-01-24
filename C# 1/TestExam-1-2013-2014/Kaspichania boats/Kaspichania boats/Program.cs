﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaspichania_boats
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.Clear();

            Console.Write(new string('.', n));
            Console.Write('*');
            Console.WriteLine(new string('.', n));
            for (int i = 0; i <= n - 2 ; i++)
            {
                Console.Write(new string('.', n - 1 - i));
                Console.Write('*');
                Console.Write(new string('.', i));
                Console.Write('*');
                Console.Write(new string('.', i));
                Console.Write('*');
                Console.WriteLine(new string('.', n - 1 - i));
            }

            Console.WriteLine(new string('*', 2 * n + 1));

            for (int i = 0; i <= n/2; i++)
            {
                if (i == n / 2)
                {
                    Console.Write(new string('.', i + 1));
                    Console.Write(new string('*', n));
                    Console.WriteLine(new string('.', i + 1));
                }
                else
                {
                    Console.Write(new string('.', i + 1));
                    Console.Write('*');
                    Console.Write(new string('.', n - 2 - i));
                    Console.Write('*');
                    Console.Write(new string('.', n - 2 - i));
                    Console.Write('*');
                    Console.WriteLine(new string('.', i + 1));
                }
            }
        }
    }
}
