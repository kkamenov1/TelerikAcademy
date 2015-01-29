using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeaceOfCake
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int C = int.Parse(Console.ReadLine());
            int D = int.Parse(Console.ReadLine());

            //decimal result = 0;
            decimal nom = ((A * D) + (B * C));
            decimal denom = (B * D);

            //result = nom / denom;

            //Console.WriteLine(result);
            if (nom > denom)
            {
                Console.WriteLine((int)(nom / denom));
            }
            else
            {
                Console.WriteLine("{0:F22}", nom / denom);
            }
            Console.WriteLine(nom + "/" + denom);
        }
    }
}
