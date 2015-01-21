﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitsExchange
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number = ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Binary representation of that number: ");
            Console.WriteLine(Convert.ToString(a, 2).PadLeft(32, '0'));
            int swapped = (a & ~(0x07000038)) // clear bits 3-5 and 24-26
            | ((a & 0x00000038) << 21) // OR in bits 3-5, shifted left 21 bits
            | ((a & 0x07000000) >> 21) // OR in bits 24-26, shifted right 21 bits
            ;
            Console.WriteLine("Result: " + swapped);
        }
    }
}
