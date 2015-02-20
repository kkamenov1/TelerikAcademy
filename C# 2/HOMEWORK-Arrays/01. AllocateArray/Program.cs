using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Write a program that allocates array of 20 integers and initializes each element by its index multiplied by 5.
// Print the obtained array on the console.

namespace _01.AllocateArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[20];
            for (int i = 0; i < 20; i++)
            {
                arr[i] = i * 5;
            }

            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
