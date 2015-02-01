using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.RandomNumbersInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter how many numbers will be printed");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter minimal value");
            int min = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter maximal value");
            int max = int.Parse(Console.ReadLine());

            Random r = new Random();
            for (int i = 1; i <= n; i++)
            {
                Console.Write("{0} ", r.Next(min, max + 1));
            }
        }
    }
}
