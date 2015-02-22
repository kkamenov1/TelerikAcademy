using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.EncodeDecode
{
    class EncodeDecode
    {
        static void Main(string[] args)
        {
            Console.Write("Enter text: ");
            string text = Console.ReadLine();
            Console.Write("Enter key: ");
            string key = Console.ReadLine();

            char[] charArr = text.ToCharArray();

            for (int i = 0; i < charArr.Length; i++)
            {
                for (int j = 0; j < key.Length; j++)
                {
                    charArr[i] ^= key[j];
                }
            }
            text = new string(charArr);
            Console.WriteLine(text);
        }
    }
}
