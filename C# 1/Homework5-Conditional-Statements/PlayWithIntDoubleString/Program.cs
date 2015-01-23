/* Problem 9. Play with Int, Double and String

Write a program that, depending on the user’s choice, inputs an int, double or string variable.
If the variable is int or double, the program increases it by one.
If the variable is a string, the program appends * at the end.
Print the result at the console. Use switch statement. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayWithIntDoubleString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please choose a type: ");
           

            Console.WriteLine("1 ---> int");
            Console.WriteLine("2 ---> double");
            Console.WriteLine("3 ---> string");

            int type = int.Parse(Console.ReadLine());

            switch (type)
            {
                case 1: Console.Write("Please enter an int: "); int n = int.Parse(Console.ReadLine()); Console.WriteLine("Result: " + (n + 1)); break;
                case 2: Console.Write("Please enter a double: "); double d = double.Parse(Console.ReadLine()); Console.WriteLine("Result: " + (d + 1)); break;
                case 3: Console.Write("Please enter a string: "); string str = Console.ReadLine(); Console.WriteLine("Result: " + (str + '*')); break;
            }
        }
    }
}
