using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.Permutations
{
    class Program
    {
        static int n = int.Parse(Console.ReadLine());
        static void Permutations (int[] arr, bool[] used, int index)
        {
            if (index == arr.Length)
            {
                Print(arr);
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    if (!used[i])
                    {
                        arr[index] = i;
                        used[i] = true;
                        Permutations(arr, used, index + 1);
                        used[i] = false;
                    }
                }
            }

        }

        private static void Print(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write((arr[i] + 1) + " ");
            }
            Console.WriteLine();
        }
        
        static void Main(string[] args)
        {
            int[] arr1 = new int[n];
            bool[] arr2 = new bool[n];
            Permutations(arr1, arr2, 0);
        }
    }
}
