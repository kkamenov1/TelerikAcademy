using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Write a program that reads two integer numbers N and K and an array of N elements from the console.
// Find in the array those K elements that have maximal sum.

namespace _06.MaximalKSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter size of the array: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Enter K: ");
            int k = int.Parse(Console.ReadLine());


            int sum = 0;
            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("a[{0}] = ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(arr);
            Array.Reverse(arr);

            for (int i = 0; i < k; i++)
            {
                sum += arr[i];
            }

            Console.WriteLine("The sum of the greatest {0} elements in the array is {1}", k, sum);
           
        }
    }
}
