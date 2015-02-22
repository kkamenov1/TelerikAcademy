using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.WorkDays
{
    class WorkDays
    {
        static DateTime[] holidays = 
        {
            new DateTime(2015, 3, 3),
            new DateTime(2015, 4, 10),
            new DateTime(2015, 5, 6),
            new DateTime(2015, 5, 5),
            new DateTime(2015, 9, 22),
        };

        static int GetWorkDays(DateTime today, DateTime nextDate)
        {
            int daysLength = Math.Abs((today - nextDate).Days);
            int counter = daysLength;
            if (today > nextDate)
            {
                today = nextDate;
                nextDate = DateTime.Now;
            }

            for (int i = 0; i < daysLength; i++)
            {
                today = today.AddDays(1);
                if (today.DayOfWeek == DayOfWeek.Saturday || today.DayOfWeek == DayOfWeek.Sunday)
                {
                    counter--;
                }

                for (int days = 0; days < holidays.Length; days++)
                {
                    if (today.CompareTo(holidays[days]) == 0)
                    {
                        counter--;
                    }
                }
            }
            return counter;
        }

        static void Main(string[] args)
        {
            DateTime today = DateTime.Now;
            Console.Write("Enter day in format YYYY/M/D: ");
            string[] dateString = Console.ReadLine().Split('/');
            int year = int.Parse(dateString[0]);
            int month = int.Parse(dateString[1]);
            int day = int.Parse(dateString[2]);

            DateTime endDate = new DateTime(year, month, day);
            Console.WriteLine("There are {0} working days between {1} and {2}!", GetWorkDays(today, endDate), today, endDate);
        }
    }
}
