using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointInsideCircleAndOutsideRectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("!!! POINT INSIDE A CIRCLE AND OUTSIDE OF A RECTANGLE !!!");
            Console.Write("Enter X coordinate: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Enter Y coordinate: ");
            double y = double.Parse(Console.ReadLine());

            if (((x - 1) * (x - 1) + (y - 1) * (y - 1) <= 1.5 * 1.5) && y > 1)
                Console.WriteLine("True");
            else Console.WriteLine("False");
        }
    }
}
