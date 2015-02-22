using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// We are given a string containing a list of forbidden words and a text containing some of these words.
// Write a program that replaces the forbidden words with asterisks.

namespace _09.ForbiddenWords
{
    class ForbiddenWords
    {
        static void Main(string[] args)
        {
            string text = @"Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";

            string[] forbiddenWords = { "Microsoft", "PHP", "CLR" };

            string[] words = text.Split(new char[] { '.', ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < words.Length; i++)
            {
                for (int j = 0; j < forbiddenWords.Length; j++)
                {
                    if (words[i] == forbiddenWords[j])
                    {
                        text = text.Replace(forbiddenWords[j], new string('*', forbiddenWords[j].Length));
                    }
                }
            }
            Console.WriteLine(text);
        }
    }
}
