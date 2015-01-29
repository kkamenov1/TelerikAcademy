using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quadronacci
{
    class Program
    {
        static void Main(string[] args)
        {
            long firstNum = long.Parse(Console.ReadLine());
            long secondNum = long.Parse(Console.ReadLine());
            long thirdNum = long.Parse(Console.ReadLine());
            long fourthNum = long.Parse(Console.ReadLine());
            int R = int.Parse(Console.ReadLine());
            int C = int.Parse(Console.ReadLine());

            if (C == 4)
            {
                Console.Write(firstNum + " " + secondNum + " " + thirdNum + " " + fourthNum);
            }
            else
            {
                Console.Write(firstNum + " " + secondNum + " " + thirdNum + " " + fourthNum + " ");
            }

            long result = 0;
            for (int row = 0; row < R; row++)
            {
                if (row == 0)
                {
                    for (int col = 4; col < C; col++)
                    {
                        result = firstNum + secondNum + thirdNum + fourthNum;
                        firstNum = secondNum;
                        secondNum = thirdNum;
                        thirdNum = fourthNum;
                        fourthNum = result;
                        Console.Write(result + " ");
                    }
                }
                else
                {
                    for (int col = 0; col < C; col++)
                    {
                        result = firstNum + secondNum + thirdNum + fourthNum;
                        firstNum = secondNum;
                        secondNum = thirdNum;
                        thirdNum = fourthNum;
                        fourthNum = result;
                        Console.Write(result + " ");
                    }
                }
                Console.WriteLine();
            }


        }
    }
}
