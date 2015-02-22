using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Dictionary
{
    class Dictionary
    {
        static void Main(string[] args)
        {
            Console.Write("Enter word: ");
            string word = Console.ReadLine();

            Dictionary<string, string> dict = new Dictionary<string,string>();

            dict.Add(".NET", "platform for applications from Microsoft");
            dict.Add("CLR", "managed execution environment for .NET");
            dict.Add("namespace", "hierarchical organization of classes");

            if (dict.ContainsKey(word))
                Console.WriteLine("Definition: " + dict[word]);
            else
                Console.WriteLine("Dictionary doesnt contain that word!");
        }
    }
}
