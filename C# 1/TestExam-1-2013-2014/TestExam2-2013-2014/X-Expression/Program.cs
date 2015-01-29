using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace X_Expression
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int size = str.Length;
            char[] expr = new char[size];
            expr = str.ToCharArray();
            char[] result = new char[size];
                for (int i = 0; i != '='; i++)
                {
                    switch (expr[i])
                    {
                        case '+': expr[i] = (char)(expr[i] + expr[i + 1]); break;
                        case '-': expr[i] = (char)(expr[i] - expr[i + 1]); break;
                        case '*': expr[i] = (char)(expr[i] * expr[i + 1]); break;
                        case '/': expr[i] = (char)(expr[i] / expr[i + 1]); break;
                    }
                }
                Console.WriteLine(expr);
            }
        }
}

