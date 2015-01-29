using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatGoikooooooyyy
{
    class Program
    {
        static void Main(string[] args)
        {
            int height = int.Parse(Console.ReadLine());

            for (int i = 0; i < height; i++)
            {
                Console.Write(new string('.', height - 1 - i));
                Console.Write('/');
                

                if (i == 1 || i == 3 || i == 6 || i == 10 || i == 15 || i == 21 || i == 28 || i == 36)
                {
                    Console.Write(new string('-', 2 * i));
                }
                else if(i == 0 || i ==2 || i == 4 || i ==5 || i == 7 || i == 8 || i == 9 || i == 11 || i ==12 || i == 13 || i == 14
                    || i == 16 || i == 17 || i == 18 || i == 18 || i ==19 || i ==20 || i ==22 || i ==23 || i == 24 || i == 25
                    || i == 26 || i == 27 || i == 29 || i == 30 || i == 31 || i == 32 || i == 33 || i == 34 || i == 35 || i == 37
                    || i == 38 || i == 39)
                {
                    Console.Write(new string('.', 2 * i));
                }
                Console.Write('\\');
                
                Console.WriteLine(new string('.', height - 1 - i));
               
                //Console.WriteLine(new string('.', height - 1 - i));
                
                

                
                

            }
        }
    }
}
