﻿using System;

class Program
{
        static void Main(string[] args)
        {
            Console.BufferHeight = 1010;
            for(int i = 2; i <= 1000; i++)
            {
                if (i % 2 == 0)
                    Console.WriteLine(i);
                else
                    Console.WriteLine(-i);
            }
        }
}