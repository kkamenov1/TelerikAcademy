using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Write a method that checks if the element at given position in given array of integers is larger than its two neighbours (when such exist).

namespace LargerThanNeighbours
{
    class LargerThanNeighbours
    {
        static bool GetLargerNumber(int position, int[] arr)
        {
            bool isGreater = false;
            if (position > 0 && position < arr.Length - 1)
            {
                if (arr[position] > arr[position + 1] && arr[position] > arr[position - 1])
                {
                    isGreater = true;
                }
            }
            else
            {
                Console.WriteLine("There is no neighbours!");
                Environment.Exit(1);
            }
            return isGreater;
        }
        
        static void Main(string[] args)
        {
            Console.Write("Enter size of the array: ");
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("a[{0}] = ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Enter position of the element to search for: ");
            int position = int.Parse(Console.ReadLine());
            if (GetLargerNumber(position, arr))
            {
                Console.WriteLine("{0} is greater than {1} and {2} ", arr[position], arr[position - 1], arr[position + 1]);
            }
            else
            {
                Console.WriteLine("{0} is not greater than {1} and {2} ", arr[position], arr[position - 1], arr[position + 1]);
            }
        }
    }
}
