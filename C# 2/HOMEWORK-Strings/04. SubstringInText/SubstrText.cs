using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SubstringInText
{
    class SubstrText
    {
        static void Main(string[] args)
        {
            Console.Write("Enter string: ");
            string input = Console.ReadLine();
            Console.Write("Enter substring to search for: ");
            string search = Console.ReadLine();
            int index = input.ToLower().IndexOf(search, 0);
            int counter = 0;
            
            while (index >= 0)
            {
                counter++;
                index++;
                index = input.ToLower().IndexOf(search, index);
            }
            Console.WriteLine(counter);
        }
    }
}
