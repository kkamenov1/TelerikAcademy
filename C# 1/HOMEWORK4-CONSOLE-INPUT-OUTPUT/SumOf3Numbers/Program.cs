using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOf3Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Enter first real number: ");
            double firstNum = double.Parse(Console.ReadLine());
            Console.Write("Enter second real number: ");
            double secondNum = double.Parse(Console.ReadLine());
            Console.Write("Enter third real number: ");
            double thirdNum = double.Parse(Console.ReadLine());
            Console.WriteLine("The sum of the {0} + {1} + {2} = {3}", firstNum, secondNum, thirdNum, firstNum + secondNum + thirdNum);
        }
    }
}
