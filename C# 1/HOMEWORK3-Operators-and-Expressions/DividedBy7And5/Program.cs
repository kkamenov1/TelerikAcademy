using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DividedBy7And5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input integer: ");
            int number = int.Parse(Console.ReadLine());

            if (number % 7 == 0 && number % 5 == 0 && number != 0) Console.WriteLine("True");
            else Console.WriteLine("False");
        }
    }
}
