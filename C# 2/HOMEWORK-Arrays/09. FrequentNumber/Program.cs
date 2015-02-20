using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.FrequentNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter size of the array: ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];
            int counter = 1;
            int maxCounter = 1;
            int counterNum = 0;

            for (int i = 0; i < n; i++)
            {
                Console.Write("a[{0}] = ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(arr);

            for (int i = 0; i < n - 1; i++)
            {
                if (arr[i] == arr[i + 1])
                {
                    counter++;
                }
                else
                {
                    counter = 1;
                }
                if (counter > maxCounter)
                {
                    maxCounter = counter;
                    counterNum = arr[i];
                }
            }
            if (maxCounter > 1)
            {
                Console.WriteLine("{0}({1})", counterNum, maxCounter);
            }
            else
            {
                Console.WriteLine("No frequency!");
            }
        }
    }
}
