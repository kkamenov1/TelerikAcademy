
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.ClassMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of rows for the first matrix: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter number of cols for the first matrix: ");
            int m = int.Parse(Console.ReadLine());

            Console.Write("Enter number of rows for the SECOND matrix: ");
            int k = int.Parse(Console.ReadLine());
            Console.Write("Enter number of cols for the SECOND matrix: ");
            int l = int.Parse(Console.ReadLine());

            Matrix matrix1 = new Matrix(n, m);
            Matrix matrix2 = new Matrix(k, l);

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write("matrix1[{0}, {1}] = ", i, j);
                    matrix1[i, j] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < k; i++)
            {
                for (int j = 0; j < l; j++)
                {
                    Console.Write("matrix2[{0}, {1}] = ", i, j);
                    matrix2[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Matrix sum = matrix1 + matrix2;
            Console.WriteLine("Your sum of the matrices is: ");
            Console.WriteLine(sum.ToString());

        }
    }
}
