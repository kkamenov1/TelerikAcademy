using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Write a method that counts how many times given number appears in given array.
// Write a test program to check if the method is workings correctly.

namespace AppearanceCount
{
    class AppearanceCount
    {
        static int GetCounter(int number, int[] arr)
        {
            int counter = 1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == number)
                    counter++;
                else
                    counter = 1;
            }
            return counter;
        }
        
        static void Main(string[] args)
        {
            Console.Write("Enter size of the array: ");
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("a[{0}] = ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Enter number to look for: ");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("The number you have entered appear {0} times!", GetCounter(number, arr));
        }
    }
}
