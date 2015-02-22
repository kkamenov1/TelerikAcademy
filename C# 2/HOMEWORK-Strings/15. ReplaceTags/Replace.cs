using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.ReplaceTags
{
    class Replace
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string replaced = input.Replace(@"<a href=""", "[URL=");
            replaced = replaced.Replace(@""">", "]");
            replaced = replaced.Replace("</a>", "/URL]");
            Console.WriteLine(replaced);
        }
    }
}
