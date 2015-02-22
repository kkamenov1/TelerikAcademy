using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.ReverseSentence
{
    class ReverseSent
    {
        static void Main(string[] args)
        {
            Console.Write("Enter string: ");
            string input = Console.ReadLine();
            Console.WriteLine(ReverseSentence(input));
        }

        static string ReverseSentence(string sentence)
        {
            StringBuilder result = new StringBuilder();
            string[] words = sentence.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = words.Length - 1; i >= 0; i--)
            {
                result.Append(words[i]);
                result.Append(' ');
            }
            return result.ToString();           
        }
    }
}
