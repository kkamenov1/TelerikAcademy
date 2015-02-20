﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.ClassMatrix
{
    class Matrix
    {
        private int[,] matrix;

        public Matrix(int rows, int cols)
        {
            this.matrix = new int[rows, cols];
        }

        public int Rows
        {
            get
            {
                return this.matrix.GetLength(0);
            }
        }

        public int Cols
        {
            get
            {
                return this.matrix.GetLength(1);
            }
        }

        public static Matrix operator +(Matrix first, Matrix second)
        {
            Matrix result = new Matrix(first.Rows, second.Rows);
            for (int row = 0; row < first.Rows; row++)
            {
                for (int col = 0; col < first.Cols; col++)
                {
                    result[row, col] = first[row, col] + second[row, col];
                }
            }
            return result;
        }

        public static Matrix operator -(Matrix first, Matrix second)
        {
            Matrix result = new Matrix(first.Rows, second.Rows);
            for (int row = 0; row < first.Rows; row++)
			{
			    for (int col = 0; col < first.Cols; col++)
			    {
                    result[row, col] = first[row, col] - second[row, col];
			    }
			}
            return result;
        }

        public static Matrix operator *(Matrix first, Matrix second)
        {
            Matrix result = new Matrix(first.Rows, first.Cols);
            for (int row = 0; row < first.Rows; row++)
			{
			    for (int col = 0; col < first.Cols; col++)
			    {
			        result[row, col] = first[row, col] * second[row, col];
			    }
			}
            return result;
        }

        public int this[int row, int col]
        {
            get
            {
                return this.matrix[row, col];
            }

            set
            {
                this.matrix[row, col] = value;
            }
        }

        public override string ToString()
        {
            string result = null;
            for (int row = 0; row < this.Rows; row++)
            {
                for (int col = 0; col < this.Cols; col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
            return result;
        }
    }
}
