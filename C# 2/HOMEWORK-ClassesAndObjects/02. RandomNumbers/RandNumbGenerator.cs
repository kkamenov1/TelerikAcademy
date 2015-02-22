using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.RandomNumbers
{
    class RandNumberGenerator
    {
        static Random rand = new Random();
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Number {0} ---> {1}", i + 1, rand.Next(100, 201));
            }
        }
    }
}
