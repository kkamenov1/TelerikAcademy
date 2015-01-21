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
            Console.Write("Input n: ");
            int n = int.Parse(Console.ReadLine());
            string initDots = new string('.', n);
            string initStar = new string('*', n);
            Console.Write(initDots);
            Console.WriteLine(initStar);

            for (int i = 1; i < n ; i++)
            {
                string dots = new string('.', n - i);
                Console.Write(dots);
                Console.Write('*');
                dots = new string('.', (n - 2) + i);
                Console.Write(dots);
                Console.WriteLine("*");
                
            }
            string finitStars = new string('*', 2 * n);
            Console.Write(finitStars);
            Console.WriteLine();
        }
    }
}
