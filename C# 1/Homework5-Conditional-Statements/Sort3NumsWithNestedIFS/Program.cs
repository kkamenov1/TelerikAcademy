using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort3NumsWithNestedIFS
{
    class Program
    {
        private static void Print(double a, double b, double c)
        {
            Console.Clear();
            Console.WriteLine("{0}  {1}  {2}", a, b, c);
        }
        
        static void Main(string[] args)
        {
            Console.Write("Enter the first number: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter the second number: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Enter the third number: ");
            double c = double.Parse(Console.ReadLine());

            if (a >= b)
            {
                if (b > c) Print(a, b, c);
                else if (c >= a) Print(c, a, b);
                else Print(a, c, b);
            }
            else if (b >= a)
            {
                if (a >= c) Print(b, a, c);
                else if (c >= b) Print(c, b, a);
                else Print(b, c, a);
            }

        }
    }
}
