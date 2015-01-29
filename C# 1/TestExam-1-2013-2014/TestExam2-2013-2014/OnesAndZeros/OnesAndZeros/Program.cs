using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnesAndZeros
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[] ch = Convert.ToString(n, 2).PadLeft(16, '0').ToCharArray();

            string str010 = ".#.";
            string str110 = "##.";
            string str101 = "#.#";
            string str111 = "###";

            StringBuilder sb1 = new StringBuilder();
            StringBuilder sb2 = new StringBuilder();
            StringBuilder sb3 = new StringBuilder();
            StringBuilder sb4 = new StringBuilder();
            StringBuilder sb5 = new StringBuilder();

            for (int j = 0; j < ch.Length; j++)
            {
                if (j != ch.Length - 1)
                {
                    if (ch[j] == '1')
                    {
                        sb1.Append(str010 + '.');
                        sb2.Append(str110 + '.');
                        sb3.Append(str010 + '.');
                        sb4.Append(str010 + '.');
                        sb5.Append(str111 + '.');
                    }
                    else
                    {
                        sb1.Append(str111 + '.');
                        sb2.Append(str101 + '.');
                        sb3.Append(str101 + '.');
                        sb4.Append(str101 + '.');
                        sb5.Append(str111 + '.');
                    }
                }
                else
                {
                    if(ch[j] == '1')
                    {
                        sb1.Append(str010);
                        sb2.Append(str110);
                        sb3.Append(str010);
                        sb4.Append(str010);
                        sb5.Append(str111);
                    }
                    else
                    {
                        sb1.Append(str111);
                        sb2.Append(str101);
                        sb3.Append(str101);
                        sb4.Append(str101);
                        sb5.Append(str111);
                    }

                }

            }
            Console.WriteLine(sb1);
            Console.WriteLine(sb2);
            Console.WriteLine(sb3);
            Console.WriteLine(sb4);
            Console.WriteLine(sb5);

        }
    }
}
