using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeastCommonMultiple
{
    class Program
    {
        static void Main(string[] args)
        {
            byte a = byte.Parse(Console.ReadLine());
            byte b = byte.Parse(Console.ReadLine());
            byte c = byte.Parse(Console.ReadLine());
            byte d = byte.Parse(Console.ReadLine());
            byte e = byte.Parse(Console.ReadLine());

            byte counter = 0;
            byte divisor = 1;

            while(true)
            {
                if (divisor >= a && divisor % a == 0) counter++;
                if (divisor >= b && divisor % b == 0) counter++;
                if (divisor >= c && divisor % c == 0) counter++;
                if (divisor >= d && divisor % c == 0) counter++;
                if (divisor >= e && divisor % e == 0) counter++;
                if (counter >= 3) break;
                else
                {
                    divisor++;
                    counter = 0;
                }

            }
            Console.WriteLine(divisor);
        }

        
    }
}
