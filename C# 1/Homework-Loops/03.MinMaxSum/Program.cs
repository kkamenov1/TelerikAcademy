using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.MinMaxSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter how many numbers will be the sequence");
            int count = int.Parse(Console.ReadLine());

            int input;
            int sum = 0;
            int maxValue = int.MinValue;
            int minValue = int.MaxValue;

            for (int i = 1; i <= count; i++)
            {
                Console.WriteLine("Enter the {0} number", i);
                input = int.Parse(Console.ReadLine());

                sum += input;
                if (input > maxValue)
                {
                    maxValue = input;
                }
                if (input < minValue)
                {
                    minValue = input;
                }
            }
            double average = (double)sum / (double)count;
            Console.WriteLine("min = {0}\nmax = {1}\nsum = {2}\navg = {3 :F2}"
                                , minValue, maxValue, sum, average);
        }
    }
}
