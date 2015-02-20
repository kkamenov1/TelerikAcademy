using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Write a program that finds the maximal increasing sequence in an array.

namespace MaximalIncreasingSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter size of the array: ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            int curCount = 1;
            int maxCount = 1;
            string curNum = "";
            string maxNum = "";

            for (int i = 0; i < n; i++)
            {
                Console.Write("a[{0}] = " , i);
                arr[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n - 1; i++)
            {
                if (arr[i] < arr[i + 1])
                {
                    curCount++;
                    curNum += arr[i] + " ";
                }
                else
                {
                    if (curCount > maxCount)
                    {
                        maxCount = curCount;
                        curNum += arr[i] + "";
                        maxNum = curNum;
                    }
                    curCount = 1;
                    curNum = "";
                }
            }
            if ( curCount > maxCount )
            {
                curNum += arr[arr.Length - 1];
                maxNum = curNum;
            }
            Console.WriteLine(maxNum);
        }
    }
}
