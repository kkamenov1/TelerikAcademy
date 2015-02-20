using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short).

namespace _08.BinaryRepresentation
{
    class BinRepresent
    {
        static string inBinary(ushort s)
        {
            string binaryNumber = string.Empty;
            for (int i = 0; i < 16; i++)
            {
                binaryNumber = (s >> i & 1) + binaryNumber;
            }

            return binaryNumber;
        }
        
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter short number: ");
                ushort number = ushort.Parse(Console.ReadLine());
                Console.WriteLine(inBinary(number));
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
