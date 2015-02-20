using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements.

namespace _02.MaximalSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of rows for the matrix: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Enter number of columns for the matrix: ");
            int m = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, m];

            if (n < 3 || m < 3)
            {
                Console.WriteLine("Invalid matrix!");
                return;
            }
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write("m[{0}, {1}] = ", i, j);
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine();
            Console.WriteLine("Your Matrix: ");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write("{0, 4}", matrix[i, j]);
                }
                Console.WriteLine();
            }

            int bestSum = int.MinValue;
            int bestRow = 0;
            int bestCol = 0;

            for (int i = 0; i < matrix.GetLength(0) - 2; i++)
            {
                for (int j = 0; j < matrix.GetLength(1) - 2; j++)
                {
                    int sum = matrix[i, j] + matrix[i, j + 1] + matrix[i, j + 2] + matrix[i + 1, j] + matrix[i + 1, j + 1] + matrix[i + 1, j + 2] +
                        matrix[i + 2, j] + matrix[i + 2, j + 1] + matrix[i + 2, j + 2];
                    if (sum > bestSum)
                    {
                        bestSum = sum;
                        bestRow = i;
                        bestCol = i;
                    }
                }   
            }
            Console.WriteLine();
            Console.WriteLine("Best platform is: ");
            Console.WriteLine("{0, 4}{1, 4}{2, 4}", matrix[bestRow, bestCol], matrix[bestRow, bestCol + 1], matrix[bestRow, bestCol + 2]);
            Console.WriteLine("{0, 4}{1, 4}{2, 4}", matrix[bestRow + 1, bestCol], matrix[bestRow + 1, bestCol + 1], matrix[bestRow + 1, bestCol + 2]);
            Console.WriteLine("{0, 4}{1, 4}{2, 4}", matrix[bestRow + 2, bestCol], matrix[bestRow + 2, bestCol + 1], matrix[bestRow + 2, bestCol + 2]);
            Console.Write("Maximal Sum(3x3) in the Matrix is: {0}", bestSum);
            Console.WriteLine();
        }
    }
}
