using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullValues
{
    class Program
    {
        static void Main(string[] args)
        {
            int? a = null;
            double? b = null;

            Console.WriteLine("Integer value is: " + a);
            Console.WriteLine("Double value is: " + b);
            Console.WriteLine();

            Console.WriteLine("Adding some number to the variables");
            a = a + 5;
            b = b + 5.5;
            Console.WriteLine("New value of int is: {0}", a);
            Console.WriteLine("New value of double is: {0}", b);

            
        }
    }
}
