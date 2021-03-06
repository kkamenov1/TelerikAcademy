﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.PrimeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            bool[] numbers = new bool[10000000];

            for (int i = 2; i < Math.Sqrt(numbers.Length); i++)
            {
                if (numbers[i] == false)
                {
                    for (int j = i * i; j < numbers.Length; j = j + i)
                    {
                        numbers[j] = true;
                    }
                }
            }

            for (int i = 2; i < numbers.Length; i++)
            {
                if (numbers[i] == false)
                {
                    Console.WriteLine("{0} ", i);
                }
            }
            Console.WriteLine();
        }
    }
}
