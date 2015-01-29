using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_6_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int C = int.Parse(Console.ReadLine());
            int result;

            if (B == 3)
            {
                result = A + C;
                if (result % 3 == 0) Console.WriteLine(result / 3);
                if (result % 3 != 0) Console.WriteLine(result % 3);
                Console.WriteLine(result);
            }
            else if (B == 6)
            {
                result = A * C;
                if (result % 3 == 0) Console.WriteLine(result / 3);
                if (result % 3 != 0) Console.WriteLine(result % 3);
                Console.WriteLine(result);
            }
            else if (B == 9)
            {
                result = A % C;
                if (result % 3 == 0) Console.WriteLine(result / 3);
                if (result % 3 != 0) Console.WriteLine(result % 3);
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Please enter B(3,6,9)!!");
                return;
            }
        }
    }
}
