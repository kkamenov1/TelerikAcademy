using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Write a program to check if in a given expression the brackets are put correctly.

namespace _03.CorrectBrackets
{
    class CorrectBrackets
    {
        static void Main(string[] args)
        {
            Console.Write("Enter string: ");
            string expression = Console.ReadLine();
            if (CheckBrackets(expression))
                Console.WriteLine("Brackets are correct!");            
            else
                Console.WriteLine("Incorrect brackets!");
        }

        static bool CheckBrackets(string expr)
        {
            int counter = 0;
            if (expr[0] == ')')
            {
                return false;
            }

            for (int i = 0; i < expr.Length; i++)
            {
                if (expr[i] == '(')
                {
                    counter++;
                }
                else if (expr[i] == ')')
                {
                    counter--;
                }
            }

            if (counter == 0)
                return true;          
            else 
                return false;
        }
    }
}
