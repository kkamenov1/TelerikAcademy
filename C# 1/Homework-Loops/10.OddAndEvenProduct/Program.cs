using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.OddAndEvenProduct
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Integers (given in a single line, separated by a space) :");
            string strNumbers = Console.ReadLine();
            string[] Numbers = strNumbers.Split(new char[] { '\u0020' }, StringSplitOptions.RemoveEmptyEntries);
            int oddProduct = 1;
            int evenProduct = 1;

            for (int i = 0; i < Numbers.Length; i++)
            {
                int currentNumber = int.Parse(Numbers[i]);
                if (i % 2 == 0)
                {
                    evenProduct *= currentNumber;
                }
                else if (i % 2 != 0)
                {
                    oddProduct *= currentNumber;
                }
            }
            bool equalProducts = oddProduct == evenProduct;
            Console.WriteLine(equalProducts ? "Yes\nProduct = {0}" : "No\nOddProduct = {0}\nEvenProduct = {1}"
                            , oddProduct, evenProduct);
        }
    }
}
