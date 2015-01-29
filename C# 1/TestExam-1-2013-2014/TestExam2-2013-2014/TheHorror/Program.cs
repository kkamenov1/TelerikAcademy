using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheHorror
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int counter = 0;
            int sum = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (i % 2 == 0)
                {
                    counter++;
                    sum += (str[i] - '0');
                }
            }
            Console.WriteLine("{0} {1}", counter, sum);
        }
    }
}
