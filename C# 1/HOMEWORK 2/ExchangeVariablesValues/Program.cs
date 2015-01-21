using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeVariablesValues
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            Console.WriteLine();
            Console.WriteLine("After the exchange: ");

            int temp = a;
            a = b;
            b = temp;

            Console.WriteLine("New a = " + a);
            Console.WriteLine("New b = " + b);
        }
    }
}
