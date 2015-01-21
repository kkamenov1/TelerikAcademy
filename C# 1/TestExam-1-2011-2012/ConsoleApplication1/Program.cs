using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        const decimal drop = 128.523123123M;
        static void Main(string[] args)
        {
            Console.Write("VUVEDETE STOINOST ZA N: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Vuvedete stoinost za M: ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.Write("VUVEDE STOINOST ZA P: ");
            int p = int.Parse(Console.ReadLine());

            double expr = (((n * n) + (1 / (m * p)) + 1337) / (n - ((double)drop * p))) + Math.Sin(m % 180);
            Console.WriteLine("The value of expression is: " + expr);
        }
    }
}
