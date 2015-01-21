using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trapezoid
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("!!! AREA OF TRAPEZOID !!!");
            Console.Write("Enter base a= ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter second base b= ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Enter height h= ");
            double h = double.Parse(Console.ReadLine());

            double area = ((a + b) / 2) * h;
            Console.WriteLine("The area of trapezoid is: " + area);

        }
    }
}
