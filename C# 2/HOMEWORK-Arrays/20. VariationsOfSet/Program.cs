using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20.VariationsOfSet
{
    class Program
    {
        static int n = int.Parse(Console.ReadLine());
        static int k = int.Parse(Console.ReadLine());

        static void Variations(int[] arr, int index)
        {
            if (index == arr.Length)
            {
                Print(arr);
            }

            else
            {
                for (int i = 1; i <= n; i++)
                {
                    arr[index] = i;
                    Variations(arr, index + 1);
                }
            }
        }

        static void Print(int[] arr)
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
            Variations(arr, 0);
        }
    }
}
