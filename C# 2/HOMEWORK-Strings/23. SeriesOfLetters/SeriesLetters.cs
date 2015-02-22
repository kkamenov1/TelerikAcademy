using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23.SeriesOfLetters
{
    class SeriesLetters
    {
        static void Main(string[] args)
        {
            Console.Write("Enter string: ");
            string text = Console.ReadLine();

            char previous = text[0];
            StringBuilder sb = new StringBuilder();
            sb.Append(previous);

            for (int i = 1; i < text.Length; i++)
            {
                if (previous != text[i])
                {
                    sb.Append(text[i]);
                }

                previous = text[i];
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
