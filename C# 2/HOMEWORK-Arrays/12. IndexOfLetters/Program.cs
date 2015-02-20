using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.IndexOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] arr = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n'
            , 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            Console.Write("Enter word: ");
            string word = Console.ReadLine();

            for (int i = 0; i < word.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (word[i] == arr[j])
                    {
                        Console.WriteLine("Letter \"{0}\" has index {1}", word[i], j);
                    }
                }
            }
        }
    }
}
