using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormattingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a = ");
            int numA = int.Parse(Console.ReadLine());
            if (0 <= numA && numA <= 500)
            {
                Console.Write("b = ");
                double numB = double.Parse(Console.ReadLine());
                Console.Write("c = ");
                double numC = double.Parse(Console.ReadLine());
                string bitNumA = Convert.ToString(numA, 2).PadLeft(10, '0');
                Console.WriteLine("|{0,-10:X}|{1}|{2,10:N2}|{3,-10:0.000}|", numA, bitNumA, numB, numC);
            }
            else
            {
                Console.WriteLine("No correct number a");

            }
        }
    }
}
