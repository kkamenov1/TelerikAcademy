using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdDigitIs7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input integer: ");
            int number = int.Parse(Console.ReadLine());

            if ((number / 100) % 10 == 7) Console.WriteLine("True");
            else Console.WriteLine("False");
        }
    }
}
