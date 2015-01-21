using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberComparer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            double firstNum = double.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            double secondNum = double.Parse(Console.ReadLine());
            Console.WriteLine("The greater of both is: {0}", firstNum > secondNum ? firstNum : secondNum);
        }
    }
}
