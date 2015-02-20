using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers.
// Use variable number of arguments.

namespace _14.IntegerCalculations
{
    class IntegerCalc
    {
        static int GetMin(int[] arr)
        {
            int min = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min)
                    min = arr[i];
            }
            return min;
        }

        static int GetMax(int[] arr)
        {
            int max = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                    max = arr[i];
            }
            return max;
        }

        static double GetAverage(int[] arr)
        {
            double sum = 0;
            double average;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return average = sum / arr.Length;
        }

        static int GetSum(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }

        static int GetProduct(int[] arr)
        {
            int product = 1;
            for (int i = 0; i < arr.Length; i++)
            {
                product *= arr[i];
            }
            return product;
        }
        
        static void Main(string[] args)
        {
            Console.Write("Enter size of the array: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < arr.Length; i++)
			{
			    Console.Write("a[{0}] = ", i);
                arr[i] = int.Parse(Console.ReadLine());
			}

            Console.WriteLine("Minimal element of the array: " + GetMin(arr));
            Console.WriteLine("Maximal element of the array: " + GetMax(arr));
            Console.WriteLine("Average: " + GetAverage(arr));
            Console.WriteLine("Sum of the elements in the array: " + GetSum(arr));
            Console.WriteLine("Product of the elements in the array: " + GetProduct(arr));
        }
    }
}
