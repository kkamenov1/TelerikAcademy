using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModifyBitAtGivenPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter integer: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Your int in binary format: " + Convert.ToString(n, 2).PadLeft(16, '0'));

            Console.Write("Enter position to extract the bit: ");
            int p = int.Parse(Console.ReadLine());

            Console.Write("Enter a bit value V(1 or 0): ");
            int v = int.Parse(Console.ReadLine());

            int mask = 1 << p;

            if (v == 0)
            {
                n = n & (~mask);
                Console.WriteLine("The new number is: " + n);
            }

            if (v == 1)
            {
                n = n | mask;
                Console.WriteLine("The new number is: " + n);
            }
        }
    }
}
