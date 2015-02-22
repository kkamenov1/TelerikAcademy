using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.SumOfIntegers
{
    class SumOfIntegers
    {
        static int GetSum(string str)
        {
            int sum = 0;
            char[] specialSymbols = new char[] { ' ' };
            string[] splittedString = str.Split(specialSymbols, StringSplitOptions.RemoveEmptyEntries);

            foreach (string number in splittedString)
            {
                sum += Convert.ToInt32(number);
            }
            return sum;
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string with digits folow with a space aftert each sequence of digits");
            string str = Console.ReadLine();
            Console.WriteLine("The sum is " + GetSum(str));
        }
    }
}
