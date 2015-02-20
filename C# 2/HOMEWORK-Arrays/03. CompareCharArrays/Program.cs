using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Write a program that compares two char arrays lexicographically (letter by letter).

namespace _03.CompareCharArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Comparing char arrays..");
            Console.Write("Enter size of the first array: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter size of the second array: ");
            int m = int.Parse(Console.ReadLine());

            bool isEqual = true;
            char[] arr1 = new char[n];
            char[] arr2 = new char[m];

            if (n == m)
            {
                for (int i = 0; i < n; i++)
                {
                    Console.Write("First char array[{0}] = ", i);
                    arr1[i] = char.Parse(Console.ReadLine());
                }

                for (int j = 0; j < m; j++)
                {
                    Console.Write("Second char array[{0}] = ", j);
                    arr2[j] = char.Parse(Console.ReadLine());
                }

                for (int i = 0; i < n; i++)
                {
                    if (arr1[i] != arr2[i])
                    {
                        isEqual = false;
                        break;
                    }
                }

            }
            else
            {
                isEqual = false;
            }
            Console.WriteLine("Equal = " + isEqual);
        }
    }
}
