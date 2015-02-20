using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21.CombinationsOfSet
{
    class Program
    {
        static int n = int.Parse(Console.ReadLine());
        static int k = int.Parse(Console.ReadLine());

        static void Combinations (int[] arr, int index, int currNum)
        {
            if (index == arr.Length)
            {
                Print(arr);
            }
            else
            {
                for (int i = currNum; i <= n; i++)
                {
                    arr[index] = i;
                    Combinations(arr, index + 1, i + 1);
                }
            }
        }

        private static void Print(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
        
        static void Main(string[] args)
        {
            int[] arr = new int[k];
            Combinations(arr, 0, 1);
        }
    }
}
