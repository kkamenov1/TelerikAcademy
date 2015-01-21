using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadraticEquation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Enter c: ");
            double c = double.Parse(Console.ReadLine());

            double d = (b * b) - (4 * a * c);
            if (d < 0) Console.WriteLine("NO REAL ROOTS!");
            double x1 = ((-b) - Math.Sqrt(d)) / 2 * a;
            double x2 = ((-b) + Math.Sqrt(d)) / 2 * a;

            Console.WriteLine("x1 = " + x1);
            Console.WriteLine("x2 = " + x2);
        }
    }
}
