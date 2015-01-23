using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeerTime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime moment1 = new DateTime(2015, 1, 22, 13, 00, 00);
            int start = moment1.Hour;
            DateTime moment2 = new DateTime(2015, 1, 23, 3, 00, 00);
            int end = moment2.Hour;

            DateTime moment3 = new DateTime();
            Console.Write("Enter hour(hh:mm tt): ");
            moment3 = DateTime.Parse(Console.ReadLine());

            if (moment3.Hour < start && moment3.Hour > end) Console.WriteLine("Non beer time!");
            else Console.WriteLine("BEER TIMEEEE!!!");

        }
    }
}
