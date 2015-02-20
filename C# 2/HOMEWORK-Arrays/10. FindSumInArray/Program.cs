using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Write a program that finds in given array of integers a sequence of given sum S (if present).

namespace _10.FindSumInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter size of the array: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Console.Write("Enter sum S: ");
            int s = int.Parse(Console.ReadLine());
            int seqSum = 0;

            for (int i = 0; i < n; i++)
            {
                Console.Write("a[{0}] = ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n - 1; i++)
            {
                seqSum += arr[i];
                for (int j = i + 1; j < n; j++)
                {
                    seqSum += arr[j];
                    if (seqSum == s)
                    {
                        for (int k = i; k <= j; k++)
                        {
                            Console.WriteLine("{0}", arr[k]);
                        }

                        break;
                    }
                }
                seqSum = 0;
            }
        }
    }
}
