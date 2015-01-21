using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissCat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("N= ");
            int judge = int.Parse(Console.ReadLine());
            int[] cats = new int[11];
            for (int i = 0; i < judge; i++)
			{
			    int mark = int.Parse(Console.ReadLine());
                cats[mark]++;
			}

            int max = 0;
            int result = 0;
            for (int i = 0; i < cats.Length; i++)
            {
                if (cats[i] > max)
                {
                    max = cats[i];
                    result = i;
                }
            }
            Console.WriteLine(result);
        }
    }
}
