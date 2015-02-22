using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24.OrderWords
{
    class Ordered
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string[] words = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Array.Sort(words);
            foreach (var word in words)
            {
                Console.Write(word + " ");
            }
            Console.WriteLine();
        }
    }
}
