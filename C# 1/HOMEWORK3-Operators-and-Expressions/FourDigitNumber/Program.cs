using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourDigitNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input 4 digit integer (e.g. 2015): ");
            int number = int.Parse(Console.ReadLine());

            int fourthDigit = number % 10;
            int thirdDigit = (number / 10) % 10;
            int secondDigit = (number / 100) % 10;
            int firstDigit = (number / 1000) % 10;

            int sumOfDigits = firstDigit + secondDigit + thirdDigit + fourthDigit;

            Console.WriteLine("Sum of digits is " + sumOfDigits);
            Console.WriteLine("Reversed: {0}{1}{2}{3}", fourthDigit, thirdDigit, secondDigit, firstDigit);
            Console.WriteLine("Last Digit in Front: {0}{1}{2}{3}", fourthDigit, firstDigit, secondDigit, thirdDigit);
            Console.WriteLine("Second and Third Digits Changed: {0}{1}{2}{3}", firstDigit, thirdDigit, secondDigit, fourthDigit);
        }
    }
}
