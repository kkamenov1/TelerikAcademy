using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// SELECTION SORT

namespace _07.SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter size of the array: ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            int i;
            for (i = 0; i < n; i++)
            {
                Console.Write("a[{0}] = ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }

            for (i = 0; i <= n - 2; i++)
            {
                int min = arr[i];
                int k = i;
                for (int j = i + 1; j <= n - 1; j++)
                {
                    if (arr[j] < min)
                    {
                        min = arr[j];
                        k = j;
                    }
                }
                int temp = arr[i];
                arr[i] = arr[k];
                arr[k] = temp;
            }

            Console.WriteLine("SELECTION SORTED ARRAY: ");
            for (i = 0; i < n; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
