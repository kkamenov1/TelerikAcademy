using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// You are given an array of strings. Write a method that sorts the array by the length of its elements (the number of characters composing them).

namespace _05.SortByStringLength
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter size of the array: ");
            int n = int.Parse(Console.ReadLine());

            string[] str = new string[n];

            for (int i = 0; i < str.Length; i++)
            {
                Console.Write("str[{0}] = ", i);
                str[i] = Console.ReadLine();
            }

            Array.Sort(str, (x, y) => x.Length.CompareTo(y.Length));
            for (int i = 0; i < str.Length; i++)
            {
                Console.WriteLine("{0}", str[i]);
            }
        }
    }
}
