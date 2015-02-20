using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Write a method that asks the user for his name and prints “Hello, <name>”

namespace _01.SayHello
{
    class Hello
    {
        static void SayHello()
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Hello, {0}!", name);
        }
        
        static void Main(string[] args)
        {
            SayHello();
        }
    }
}
