using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForestRoad
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Vuvedete n= ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n-1; i++)
            {
                string dots = new string('.', i);

                Console.Write(dots);
                Console.Write('*');

                dots = new string('.', (n - 1) - i);

                Console.WriteLine(dots);

            }
            for(int i = n-1; i >= 0; i--)
            {
                string dots = new string('.', i);

                Console.Write(dots);
                Console.Write('*');

                dots = new string('.', (n - 1) - i);

                Console.WriteLine(dots);
            }
            
        }
    }
}
