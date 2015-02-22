using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.StringLength
{
    class StrLen
    {
        static void Main(string[] args)
        {
            Console.Write("Enter string with maximum length 20: ");
            string input = Console.ReadLine();

            if (input.Length > 20)
            {
                Console.WriteLine("Invalid length!");
                Environment.Exit(1);
            }

            else if (input.Length == 20)
            {
                Console.WriteLine(input);
            }
            else if (input.Length < 20)
            {
                Console.WriteLine(input + (new string('*', 20 - input.Length)));
            }

            
        }
    }
}
