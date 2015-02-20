using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Write a program, that reads from the console an array of N integers and an integer K, 
// sorts the array and using the method Array.BinSearch() finds the largest number in the array which is ≤ K.

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter size of the array: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Enter K: ");
            int k = int.Parse(Console.ReadLine());

            int[] arr = new int[n];
            int result;

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("a[{0}] = ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(arr);
            
            if (arr[0] > k)
            {
                Console.WriteLine("There is no number that is smaller than or equal to K!");
            }
            else
            {
                int index = Array.BinarySearch(arr, k);
                if (index >= 0)
                {
                    result = arr[index];
                    Console.WriteLine("Index number: " + index + " With value : " + result);
                }
                else
                {
                    Console.WriteLine("Value not found : " + index);
                }
            }

        }
    }
}
