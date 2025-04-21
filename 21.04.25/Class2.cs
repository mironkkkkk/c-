using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Matrix
    {
        private int row;
        private int column;
        private int[,] arr;

        public Matrix(int row, int column) {
            this.row = row;
            this.column = column;
            this.arr = new int[row, column];
            for (int i = 0; i < this.row; i++) {
                for (int j = 0; j < this.column; j++) {
                    arr[i, j] = j;
                }
            }
        }

        public void print() {
            for (int i = 0; i < this.row; i++) {
                for (int j = 0; j < this.column; j++) {
                    Console.Write($"{arr[i, j]} ");
                }
                Console.WriteLine();
            }
        }

        public static Matrix operator +(Matrix arr1, Matrix arr2) {
            Matrix arr3 = new Matrix(arr1.row, arr1.column);
            for (int i = 0; i < arr1.row; i++) {
                for (int j = 0; j < arr1.column; j++) {
                    arr3.arr[i, j] = arr1.arr[i, j] + arr2.arr[i, j];
                }
            }
            return arr3;
        }

        public static Matrix operator -(Matrix arr1, Matrix arr2)
        {
            Matrix arr3 = new Matrix(arr1.row, arr1.column);
            for (int i = 0; i < arr1.row; i++)
            {
                for (int j = 0; j < arr1.column; j++)
                {
                    arr3.arr[i, j] = arr1.arr[i, j] - arr2.arr[i, j];
                }
            }
            return arr3;
        }

        public static Matrix operator *(Matrix arr1, Matrix arr2)
        {
            Matrix arr3 = new Matrix(arr1.row, arr1.column);
            for (int i = 0; i < arr1.row; i++)
            {
                for (int j = 0; j < arr1.column; j++)
                {
                    arr3.arr[i, j] = arr1.arr[i, j] * arr2.arr[i, j];
                }
            }
            return arr3;
        }

        public static bool operator ==(Matrix arr1, Matrix arr2)
        {
            for (int i = 0; i < arr1.row; i++)
            {
                for (int j = 0; j < arr1.column; j++)
                {
                    if (arr1.arr[i, j] != arr2.arr[i, j]) {
                        return false;
                    }
                }
            }
            return true;
        }

        public static bool operator !=(Matrix arr1, Matrix arr2)
        {
            for (int i = 0; i < arr1.row; i++)
            {
                for (int j = 0; j < arr1.column; j++)
                {
                    if (arr1.arr[i, j] != arr2.arr[i, j])
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
