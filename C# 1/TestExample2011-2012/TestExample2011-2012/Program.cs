using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestExample2011_2012
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            Console.Write("X= ");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Y= ");
            y = int.Parse(Console.ReadLine());
            if (x > 0 && y > 0)
                Console.WriteLine("The number is in 1");
            if (x < 0 && y > 0)
                Console.WriteLine("The number is in 2");
            if (x < 0 && y < 0) Console.WriteLine("The number is in 3");
            if (x > 0 && y < 0) Console.WriteLine("The number is in 4");
            if (x == 0 && y == 0) Console.WriteLine("The number is in 0");
            if ((x == 0 && y > 0) || (x == 0 && y < 0)) Console.WriteLine("The number is 5");
            if ((y == 0 && x < 0) || (y == 0 && x > 0))  Console.WriteLine("The number is 6");
        }
    }
}
