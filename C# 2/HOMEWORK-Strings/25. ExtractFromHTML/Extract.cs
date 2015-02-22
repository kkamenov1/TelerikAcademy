using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25.ExtractFromHTML
{
    class Extract
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            StringBuilder result = new StringBuilder();
            bool openTag = false;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == '<')
                {
                    openTag = true;
                }
                if (!openTag)
                {
                    result.Append(text[i]);
                    if (text[i + 1] == '<')
                    {
                        result.AppendLine();
                    }
                }
                if (text[i] == '>')
                {
                    openTag = false;
                }
            }
            Console.WriteLine(result.ToString().Trim());
        }
    }
}
