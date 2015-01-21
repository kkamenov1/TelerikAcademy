using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointInACircle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter X coordinate: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Enter Y coordinate: ");
            int y = int.Parse(Console.ReadLine());

            bool isInCircle = (x * x + y * y <= 2*2);

            if (isInCircle) Console.WriteLine("The point is in the circle");
            else Console.WriteLine("The point is outside the circle");

        }
    }
}
