using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Fillmatrix
{
    class Program
    {
        static void FillMatrixA(int[,] matrix, int n)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[j, i] = j + 1 + (n * i);
                }
            }
        }

        static void FillMatrixB(int[,] matrix, int n)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if ((i % 2) == 0)
                    {
                        matrix[j, i] = j + 1 + (n * i);
                    }
                    else
                    {
                        matrix[n - j - 1, i] = j + 1 + (n * i);
                    }
                }
            }
        }

        static void FillMatrixC(int[,] matrix, int n)
        {
            int rows = n - 1;
            int cols = 0;
            int value = 1;

            for (int i = 0; i < n * n; i++)
            {
                matrix[rows, cols] = value;
                rows++;
                cols++;
                value++;

                if (rows == n || cols == n)
                {
                    rows--;
                    if (cols == n)
                    {
                        rows--;
                        cols--;
                    }
                    while (rows - 1 >= 0 && cols - 1 >= 0)
                    {
                        rows--;
                        cols--;
                    }
                }
            }
        }

        static void FillMatrixD(int[,] matrix, int n)
        {
            int value = 1;

            // top rows and cols of the matrix
            for (int i = 0; i < n; i++)
            {
                for (int j = i; j < n - i; j++)
                {
                    matrix[i, j] = value;
                    value++;
                }

                for (int j = 0; j < n - 1 - i * 2; j++) // right rows and cols
                {
                    matrix[j + 1 + i, n - i - 1] = value;
                    value++;
                }

                for (int j = 0; j < n - 1 - i * 2; j++) // bottom rows and cols
                {
                    matrix[n - 1 - i, n - j - 2 - i] = value;
                    value++;
                }

                for (int j = 0; j < n - 2 - i * 2; j++) // left cols and rows
                {
                    matrix[n - j - 2 - i, i] = value;
                    value++;
                }
            }

            

        }


        static void PrintMatrix(int[,] matrix, int n)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write("{0, 4}", matrix[i, j]);
                }
                Console.WriteLine();
            }
        }


        static void Main(string[] args)
        {
            Console.Write("Enter size of matrix: ");
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            FillMatrixA(matrix, n);
            PrintMatrix(matrix, n);

            Console.WriteLine();

            FillMatrixB(matrix, n);
            PrintMatrix(matrix, n);

            Console.WriteLine();

            FillMatrixC(matrix, n);
            PrintMatrix(matrix, n);

            Console.WriteLine();

            FillMatrixD(matrix, n);
            PrintMatrix(matrix, n);
        }
    }
}
