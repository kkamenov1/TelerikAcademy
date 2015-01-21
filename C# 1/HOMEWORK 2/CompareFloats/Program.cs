using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareFloats
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your first floating number: ");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter your second floating number: ");
            double b = double.Parse(Console.ReadLine());

            bool equal = Math.Abs(a - b) < 0.000001;

            Console.WriteLine("{0} == {1} --> {2}", a, b, equal);
        }
    }
}
