using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.ParseTags
{
    class Parse
    {
        static void Main(string[] args)
        {
            string text = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";

            StringBuilder upperCaseText = new StringBuilder();

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == '<')
                {
                    i += 8;
                    while (text[i] != '<')
                    {
                        upperCaseText.Append(text[i].ToString().ToUpper());
                        i++;
                    }
                    i += 8;
                }
                else
                    upperCaseText.Append(text[i]);
            }
            Console.WriteLine(upperCaseText.ToString());
        }
    }
}
