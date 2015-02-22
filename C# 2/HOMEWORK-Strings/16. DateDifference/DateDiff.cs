using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.DateDifference
{
    class DateDiff
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first date in format day.month.year: ");
            DateTime firstDate = DateTime.Parse(Console.ReadLine());
            Console.Write("Enter second date in format day.month.year: ");
            DateTime secondDate = DateTime.Parse(Console.ReadLine());

            TimeSpan difference = firstDate - secondDate;
            Console.WriteLine("Distance: " + Math.Abs(difference.Days));
        }
    }
}
