using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Globalization;

namespace _19.CanadaDate
{
    class CanadaDate
    {
        static void Main(string[] args)
        {
            string text = "Meet Pesho at 15.03.2012 or 16.02.2002";
            DateTime date;

            foreach (var item in Regex.Matches(text, @"\d+\.\d+\.\d+"))
            {
                string[] dateArr = item.ToString().Split('.');
                date = new DateTime(int.Parse(dateArr[2]), int.Parse(dateArr[1]), int.Parse(dateArr[0]));
                System.Threading.Thread.CurrentThread.CurrentCulture = new CultureInfo("en-CA");
                Console.WriteLine(date.ToString("dddd, MMMM dd, yyyy h:mm:ss tt"));
            }
        }
    }
}
