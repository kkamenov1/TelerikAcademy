using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryDigitsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input number (0 or 1): ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Input integer: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Binary representation of the integer: {0}", Convert.ToString(n, 2));
            Console.WriteLine();

            uint number;
            int countBitsOnes, countBitsZeros;

            for (int i = 0; i < n; i++)
            {
                countBitsOnes = countBitsZeros = 0;
                int powerOfTwo = 0;
                number = uint.Parse(Console.ReadLine());
                while(number != 0)
                {
                    if ((number & 1) == 1)
                        countBitsOnes++;
                    else
                        countBitsZeros++;
                    number >>= 1;
                }
                if (b == 1)
                {
                    Console.WriteLine(countBitsOnes);
                }
                else
                    Console.WriteLine(countBitsZeros);

            }
            
        }
    }
}
