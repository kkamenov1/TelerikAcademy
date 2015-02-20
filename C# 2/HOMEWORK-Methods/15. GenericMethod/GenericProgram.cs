using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _14.IntegerCalculations
{
    class GenericProgram
    {
        static T GetMin<T>(T[] arr)
        {
            dynamic min = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min)
                    min = arr[i];
            }
            return min;
        }

        static T GetMax<T>(T[] arr)
        {
            dynamic max = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                    max = arr[i];
            }
            return max;
        }

        static T GetAverage<T>(T[] arr)
        {
            dynamic sum = 0;
            dynamic average;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return average = sum / arr.Length;
        }

        static T GetSum<T>(T[] arr)
        {
            dynamic sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }

        static T GetProduct<T>(T[] arr)
        {
            dynamic product = 1;
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
