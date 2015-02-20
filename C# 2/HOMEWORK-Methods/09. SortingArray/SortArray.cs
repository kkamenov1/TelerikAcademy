using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Write a method that return the maximal element in a portion of array of integers starting at given index.
// Using it write another method that sorts an array in ascending / descending order.
namespace _09.SortingArray
{
    class SortArray
    {
        static int MaxElem(int position, int[] arr, bool ascending = true)
        {
            int max = position;
            for (position++; position < arr.Length; position++)
            {
                if (ascending)
                {
                    if (arr[position] < arr[max])
                    {
                        max = position;
                    }
                }
                else
                {
                    if (arr[position] > arr[max])
                    {
                        max = position;
                    }
                }
            }
            return max;
        }

        static void Swap(int[] arr, int i, int j)
        {
            int t = arr[i];
            arr[i] = arr[j];
            arr[j] = t;
        }

        static void Sort(int[] arr, bool ascending = true)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Swap(arr, i, MaxElem(i, arr, ascending));
            }
        }

        static void Print(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + (i == arr.Length - 1 ? "\n" : " "));
            }
        }

        static void Main(string[] args)
        {
            int[] array = { 1, 3, 56, -2, -21, 22 };

            Sort(array);// Ascending
            Print(array);

            Sort(array, false);// Descending
            Print(array);
        }
    }
}
