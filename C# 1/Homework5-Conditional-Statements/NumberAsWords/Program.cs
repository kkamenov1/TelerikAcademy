using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberAsWords
{
    class Program
    {
        static void PrintHundreds(int num)
        {
            switch (num)
            {
                case 1: Console.Write("One hundred "); break;
                case 2: Console.Write("Two hundred "); break;
                case 3: Console.Write("Three hundred "); break;
                case 4: Console.Write("Four hundred "); break;
                case 5: Console.Write("Five hundred "); break;
                case 6: Console.Write("Six hundred "); break;
                case 7: Console.Write("Seven hundred "); break;
                case 8: Console.Write("Eight hundred "); break;
                case 9: Console.Write("Nine hundred "); break;
                default: Console.Write(" "); break;
            }
        }

        static void PrintNumbers(int num)
        {
            switch (num)
            {
                case 0: Console.WriteLine("zero"); break;
                case 1: Console.WriteLine("one"); break;
                case 2: Console.WriteLine("two"); break;
                case 3: Console.WriteLine("three"); break;
                case 4: Console.WriteLine("four"); break;
                case 5: Console.WriteLine("five"); break;
                case 6: Console.WriteLine("six"); break;
                case 7: Console.WriteLine("seven"); break;
                case 8: Console.WriteLine("eight"); break;
                case 9: Console.WriteLine("nine"); break;
                case 10: Console.WriteLine("ten"); break;
                case 11: Console.WriteLine("eleven"); break;
                case 12: Console.WriteLine("twelve"); break;
                case 13: Console.WriteLine("thirteen"); break;
                case 14: Console.WriteLine("fourteen"); break;
                case 15: Console.WriteLine("fifteen"); break;
                case 16: Console.WriteLine("sixteen"); break;
                case 17: Console.WriteLine("seventeen"); break;
                case 18: Console.WriteLine("eighteen"); break;
                default: Console.WriteLine("nineteen"); break;
            }
        }
        
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            if (n >= 0 && n <= 19)
            {
                PrintNumbers(n);
            }
            else if (n >= 20 && n < 100)
            {
                switch (n / 10)
                {
                    case 2: Console.Write("twenty "); break;
                    case 3: Console.Write("thirty "); break;
                    case 4: Console.Write("fourty "); break;
                    case 5: Console.Write("fifty "); break;
                    case 6: Console.Write("sixty "); break;
                    case 7: Console.Write("seventy "); break;
                    case 8: Console.Write("eighty "); break;
                    case 9: Console.Write("ninety "); break;
                    default: Console.Write(" "); break;
                }

                switch (n % 10)
                {
                    case 0: Console.WriteLine(" "); break;
                    case 1: Console.WriteLine("one"); break;
                    case 2: Console.WriteLine("two"); break;
                    case 3: Console.WriteLine("three"); break;
                    case 4: Console.WriteLine("four"); break;
                    case 5: Console.WriteLine("five"); break;
                    case 6: Console.WriteLine("six"); break;
                    case 7: Console.WriteLine("seven"); break;
                    case 8: Console.WriteLine("eight"); break;
                    default: Console.WriteLine("nine"); break;
                }
            }

            else if (n >= 100 && n < 1000)
            {
                if ((n % 100) > 0 && (n % 100) <= 19)
                {
                    PrintHundreds(n / 100);
                    Console.Write(" and ");
                    PrintNumbers(n % 100);
                }
                else
                {
                    PrintHundreds(n / 100);
                    switch ((n / 10) % 10)
                    {
                        case 2: Console.Write("twenty "); break;
                        case 3: Console.Write("thirty "); break;
                        case 4: Console.Write("fourty "); break;
                        case 5: Console.Write("fifty "); break;
                        case 6: Console.Write("sixty "); break;
                        case 7: Console.Write("seventy "); break;
                        case 8: Console.Write("eighty "); break;
                        case 9: Console.Write("ninety "); break;
                        default: Console.Write(" "); break;
                    }

                    switch (n % 10)
                    {
                        case 0: Console.WriteLine(" "); break;
                        case 1: Console.WriteLine("one"); break;
                        case 2: Console.WriteLine("two"); break;
                        case 3: Console.WriteLine("three"); break;
                        case 4: Console.WriteLine("four"); break;
                        case 5: Console.WriteLine("five"); break;
                        case 6: Console.WriteLine("six"); break;
                        case 7: Console.WriteLine("seven"); break;
                        case 8: Console.WriteLine("eight"); break;
                        case 9: Console.WriteLine("nine"); break;
                        default: Console.WriteLine(" "); break;
                    }
                }
            }
        }
    }
}
