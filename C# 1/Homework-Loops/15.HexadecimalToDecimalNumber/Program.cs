﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.HexadecimalToDecimalNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a hexadecimal integer number :");
            string hex = Console.ReadLine();
            long number = 0;
            long power = 1;

            for (int i = hex.Length - 1; i >= 0; i--)
            {
                int sign;
                switch (hex[i])
                {
                    case 'A': sign = 10;
                        break;
                    case 'B': sign = 11;
                        break;
                    case 'C': sign = 12;
                        break;
                    case 'D': sign = 13;
                        break;
                    case 'E': sign = 14;
                        break;
                    case 'F': sign = 15;
                        break;
                    default: sign = hex[i] - 48;
                        break;
                }
                number += sign * power;
                power *= 16;
            }
            Console.WriteLine(number);
        }
    }
}
