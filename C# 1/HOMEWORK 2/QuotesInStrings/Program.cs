using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuotesInStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string one = "The \"use\" of quotes causes difficulties.";
            string two = @"The ""use"" of quotes causes difficulties.";
            Console.WriteLine(one);
            Console.WriteLine(two);
        }
    }
}
