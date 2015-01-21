using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumberCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            int n = int.Parse(Console.ReadLine());

            bool prime = true;
            if (n < 2) Console.WriteLine("False");
            else
            {
                for (int i = 2; i < n ; i++)
                {
                    if (n % i == 0) prime = false;
                }
            }
            Console.WriteLine(prime);

            
        }
    }
}
