using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitwiseExtractBit3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter integer: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Your int in binary format: " + Convert.ToString(n, 2).PadLeft(16, '0'));
            int mask = 1 << 3;
            int nAndMask = n & mask;
            int bit = nAndMask >> 3;
            Console.WriteLine(bit);
        }
    }
}
