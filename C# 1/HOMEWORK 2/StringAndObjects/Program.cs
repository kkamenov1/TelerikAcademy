﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            string one = "Hello, ";
            string two = "World!";
            object concat = one + two;
            Console.WriteLine(concat);
        }
    }
}
