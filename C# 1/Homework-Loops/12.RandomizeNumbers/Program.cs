using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.RandomizeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

        int[] pool = new int[n];
        bool[] printed = new bool[n + 1];
        Random r = new Random();
        int randomized = r.Next(1, n + 1);

        for (int index = 0; index < n; index++)
        {
            randomized = r.Next(1, n + 1);
            if (!printed[randomized])
            {
                Console.Write("{0} ", randomized);
                printed[randomized] = true;
            }
            else
            {
                index--;
            }
        }
        Console.WriteLine();
        }
    }
}
