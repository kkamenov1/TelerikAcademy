using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Write a program that finds the sequence of maximal sum in given array.

namespace _08.MaximalSequenceSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter size of the array: ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("a[{0}] = ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }

            int curSum = arr[0];
            int maxSum = arr[0];
            int startIndex = 0;
            int endIndex = 0;
            int tempIndex = 0;

            for (int i = 0; i < n; i++)
            {
                if (curSum <= 0)
                {
                    startIndex = i;
                    curSum = 0;
                }

                curSum += arr[i];

                if (curSum > maxSum)
                {
                    maxSum = curSum;
                    tempIndex = startIndex;
                    endIndex = i;
                }
            }

            Console.Write("The best sequence is: ");
            for (int i = startIndex; i <= endIndex; i++)
            {
                Console.Write(arr[i] + " ");

            }
            Console.WriteLine();
            Console.WriteLine("The max sum is: " + maxSum);
        }
    }
}
