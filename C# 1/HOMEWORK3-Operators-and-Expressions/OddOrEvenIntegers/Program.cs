using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddOrEvenIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input integer: ");
            int number = int.Parse(Console.ReadLine());
            if (number % 2 == 0) Console.WriteLine("The integer is even!");
            else Console.WriteLine("The integer is odd!");
        }
    }
}
