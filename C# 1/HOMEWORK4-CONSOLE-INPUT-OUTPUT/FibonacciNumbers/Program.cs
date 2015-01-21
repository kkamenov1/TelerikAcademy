using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            int firstNum = 0;
            int secondNum = 1;
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(firstNum);
                sum = firstNum + secondNum;
                firstNum = secondNum;
                secondNum = sum;
            }
        }
    }
}
