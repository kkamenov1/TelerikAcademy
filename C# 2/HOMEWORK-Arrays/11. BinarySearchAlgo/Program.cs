using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Write a program that finds the index of given element in a sorted array of integers by using the Binary search algorithm.

namespace _11.BinarySearchAlgo
{
    class Program
    {
        static int BinSearch(int[] arr, int x)
        {
            int first = 0;
            int last = arr.Length - 1;

            while (first <= last)
            {
                int mid = (first + last) / 2;
                if (arr[mid] < x)
                {
                    first = mid + 1;
                }

                else if (arr[mid] > x)
                {
                    last = mid - 1;
                }
                else 
                    return mid;
            }
            return -1;
        }
        
        static void Main(string[] args)
        {
            int[] sortedArr = new int[8] { 3, 1, 5, 4, 8, 12, 2, 20 };
            Array.Sort(sortedArr);
            int key = 4;
            Console.WriteLine(BinSearch(sortedArr, key));
        }
    }
}
