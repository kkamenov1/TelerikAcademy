using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Write a method that reverses the digits of given decimal number.

namespace ReverseNumber
{
    class ReverseNumber
    {
        static decimal ReverseNum(decimal number)
        {
            return decimal.Parse(new string(number.ToString().Reverse().ToArray()));
        }
        
        static void Main(string[] args)
        {
            Console.Write("Enter decimal number: ");
            decimal number = decimal.Parse(Console.ReadLine());

            Console.Write("Reversed: ");
            decimal reversed = ReverseNum(number);
            Console.WriteLine(reversed);
        }
    }
}
