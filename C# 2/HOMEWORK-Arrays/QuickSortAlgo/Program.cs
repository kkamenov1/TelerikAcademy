using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSortAlgo
{
    class Program
    {
        static List<int> QuickSort (List<int> arr)
        {
            if (arr.Count <= 1)
            {
                return arr;
            }

            int pivot = arr[arr.Count / 2];
            List<int> less = new List<int>();
            List<int> greater = new List<int>();

            for (int i = 0; i < arr.Count; i++)
            {
                if (i != arr.Count / 2)
                {
                    if (arr[i] <= pivot)
                    {
                        less.Add(arr[i]);
                    }
                    else
                    {
                        greater.Add(arr[i]);
                    }
                }
            }
            return ConcatenateArr(QuickSort(less), QuickSort(greater), pivot);

        }

        static List<int> ConcatenateArr(List<int> less, List<int> greater, int pivot)
        {
            List<int> result = new List<int>();

            for (int i = 0; i < less.Count; i++)
            {
                result.Add(less[i]);
            }

            result.Add(pivot);

            for (int i = 0; i < greater.Count; i++)
            {
                result.Add(greater[i]);
            }
            return result;
        }
        
        
        
        static void Main(string[] args)
        {
            List<int> arr = new List<int>() { 2, 1, 6, 8, 5, 3, 9 };
            List<int> sortedArr = QuickSort(arr);
            Print(sortedArr);
        }

        private static void Print(List<int> sortedArr)
        {
            for (int i = 0; i < sortedArr.Count; i++)
            {
                Console.WriteLine(sortedArr[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
