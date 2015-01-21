using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CirclePerimeterAndArea
{
    class Program
    {
        const double pi = 3.14159265359;
        static void Main(string[] args)
        {
            Console.WriteLine("<--------CIRCLE PERIMETER AND AREA-------->");
            Console.Write("Input radius of the circle: ");
            double r = double.Parse(Console.ReadLine());

            Console.WriteLine("The perimeter of the circle is: {0:0.00}", 2 * pi * r);
            Console.WriteLine("The area of the circle is: {0:0.00}", pi * r * r);
        }
    }
}
