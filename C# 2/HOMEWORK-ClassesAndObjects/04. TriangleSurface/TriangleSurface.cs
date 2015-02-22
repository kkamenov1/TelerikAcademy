using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Write methods that calculate the surface of a triangle by given:
// Side and an altitude to it;
// Three sides;
// Two sides and an angle between them;
// Use System.Math.

namespace _04.TriangleSurface
{
    class TriangleSurface
    {
        static double SurfaceSideAltitude(double side, double h)
        {
            double surface = 0;
            surface = (side * h) / 2;
            return surface;
        }

        static double SurfaceThreeSides(double a, double b, double c)
        {
            double surface = 0;
            double p = (a + b + c) / 2;
            surface = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return surface;
        }

        static double SurfaceTwoSidesAngle(double a, double b, double angle)
        {
            double surface = 0;
            surface = (a * b * Math.Sin(angle)) / 2;
            return surface;
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("Finding Surface of a Triangle by side and altitude: ");
            Console.Write("Enter side: ");
            double side = double.Parse(Console.ReadLine());
            Console.Write("Enter altitude: ");
            double h = double.Parse(Console.ReadLine());
            Console.WriteLine("The surface is " + SurfaceSideAltitude(side, h));
            Console.WriteLine(new string('*', 40));
            Console.WriteLine("Finding Surface of a Triangle by three sides: ");
            Console.Write("Enter first side: "); double side1 = double.Parse(Console.ReadLine());
            Console.Write("Enter second side: "); double side2 = double.Parse(Console.ReadLine());
            Console.Write("Enter third side: "); double side3 = double.Parse(Console.ReadLine());
            Console.WriteLine("The surface is " + SurfaceThreeSides(side1, side2, side3));
            Console.WriteLine(new string('*', 40));
            Console.WriteLine("Finding Surface of a Triangle by two sides and angle between them: ");
            Console.Write("Enter first side: "); double side11 = double.Parse(Console.ReadLine());
            Console.Write("Enter second side: "); double side22 = double.Parse(Console.ReadLine());
            Console.Write("Enter angle: "); double angle = double.Parse(Console.ReadLine());
            Console.WriteLine("The Surface is " + SurfaceTwoSidesAngle(side11, side22, angle));
            Console.WriteLine(new string('*', 40));
        }
    }
}
