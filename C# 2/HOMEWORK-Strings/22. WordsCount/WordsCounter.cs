using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22.WordsCount
{
    class WordsCounter
    {
        static void Main(string[] args)
        {
            Console.Write("Enter string: ");
            string text = Console.ReadLine();

            string[] words = text.Split(new char[] { ' ', ',', '.' }, StringSplitOptions.RemoveEmptyEntries);
            bool[] visited = new bool[words.Length];

            for (int i = 0; i < words.Length; i++)
            {
                int count = 1;

                if (visited[i] == false)
                {
                    for (int j = i + 1; j < words.Length - 1; j++)
                    {
                        if (words[i] == words[j])
                        {
                            count++;
                            visited[j] = true;
                        }
                    }
                    visited[i] = true;
                    Console.WriteLine(words[i] + " ---> " + count);
                }
            }
        }
    }
}
