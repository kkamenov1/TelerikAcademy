using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.FormatNumber
{
    class NumberFormatting
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your number: ");
            string number = Console.ReadLine();
            Console.WriteLine("Number as decimal: ");
            PrintAsDecimal(number);
            Console.WriteLine("Number as hexadecimal: ");
            PrintAsHex(number);
            Console.WriteLine("Number as scientific: ");
            PrintAsScientific(number);
            Console.WriteLine("Number as percent: ");
            PrintAsPercent(number);
        }

        static void PrintAsDecimal(string number)
        {
            Console.WriteLine("{0,15:D}", int.Parse(number));
        }

        static void PrintAsHex(string number)
        {
            Console.WriteLine("{0,15:X}", int.Parse(number));
        }

        static void PrintAsPercent(string number)
        {
            Console.WriteLine("{0,15:P}", double.Parse(number) / 100);
        }

        static void PrintAsScientific(string number)
        {
            Console.WriteLine("{0,15:E}", number);
        }
    }
}
