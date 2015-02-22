using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Write a program that extracts from a given text all sentences containing given word.

namespace _08.ExtractSentences
{
    class ExtractSentence
    {
        static void Main(string[] args)
        {
            Console.Write("Enter text: ");
            string text = Console.ReadLine();
            Console.Write("Enter keyword to search for: ");
            string keyword = Console.ReadLine();

            string[] sentences = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var sentence in sentences)
            {
                string[] words = sentence.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < words.Length; i++)
                {
                    if (keyword == words[i])
                    {
                        Console.WriteLine(sentence.Trim() + '.');
                    }
                }
            }           
        }
    }
}
