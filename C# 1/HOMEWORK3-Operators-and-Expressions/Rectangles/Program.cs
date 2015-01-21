using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input width: ");
            double width = double.Parse(Console.ReadLine());
            Console.Write("Input height: ");
            double height = double.Parse(Console.ReadLine());

            double perimeter = 2 * width + 2 * height;
            double area = width * height;
            Console.WriteLine("Area of the rectangle is " + area);
            Console.WriteLine("Perimeter of the rectangle is " + perimeter);

        }
    }
}
