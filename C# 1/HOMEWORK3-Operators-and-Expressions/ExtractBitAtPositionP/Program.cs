using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtractBitAtPositionP
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

            int mask = 1 << p;
            int nAndMask = n & mask;
            int bit = nAndMask >> p;

            Console.WriteLine(bit);
        }
    }
}
