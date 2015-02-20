using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Write a program that finds the maximal sequence of equal elements in an array.

namespace _04.MaximalSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the size of the array: ");
            int n = int.Parse(Console.ReadLine());
            int maxCount = 1;
            int curCount = 1;
            int value = 0;
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("arr[{0}] = ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n - 1; i++)
            {
                if (arr[i] == arr[i + 1])
                {
                    curCount++;
                }
                else
                {
                    curCount = 1;
                }
                if (curCount >= maxCount)
                {
                    maxCount = curCount;
                    value = arr[i];
                }
            }
            for (int i = 0; i < maxCount; i++)
            {
                Console.Write("{0}, ", value);
            }
            Console.WriteLine();
        }
    }
}