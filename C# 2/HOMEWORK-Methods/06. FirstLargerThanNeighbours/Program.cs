using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Write a method that returns the index of the first element in array that is larger than its neighbours, or -1, if there’s no such element.
// Use the method from the previous exercise.
namespace _06.FirstLargerThanNeighbours
{
    class Program
    {
        static int GetLargerNumber(int[] arr)
        {
            int position;
            position = -1;

            for (int i = 1; i < arr.Length - 1; i++)
            {
                if (arr[i] > arr[i - 1] && arr[i] > arr[i + 1])
                {
                    position = i;
                    break;
                }
            }
            return position;
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

            int position = GetLargerNumber(arr);
            if (position > 0)
            {
                Console.WriteLine("The element is on postion " + position);
            }
            else
            {
                Console.WriteLine("No such element exists");
            }
        }
    }
}
