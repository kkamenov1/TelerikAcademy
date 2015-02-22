using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Write a program that converts a string to a sequence of C# Unicode character literals.
// Use format strings.
namespace _10.UnicodeChars
{
    class UnicodeCharacters
    {
        static void Main(string[] args)
        {
            Console.Write("Enter string: ");
            string input = Console.ReadLine();

            StringBuilder converter = new StringBuilder();

            foreach (var ch in input)
            {
                converter.AppendFormat("u\\{0:X4}", (int)ch);
            }

            Console.WriteLine(converter.ToString());
        }
    }
}
