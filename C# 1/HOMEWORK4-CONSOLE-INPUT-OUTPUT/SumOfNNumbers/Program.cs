using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfNNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            double sum = 0;

            for (int i = 1; i <= n; i++)
            {
                Console.Write("Enter the {0} number: ", i);
                double numI = double.Parse(Console.ReadLine());
                sum += numI;
            }
            Console.WriteLine("The sum is: " + sum);
        }
    }
}
