using System;

namespace SymmetricMatrix
{
    class Program
    {
        public static void Main(string[] args)
        {
            //EXAMPLE:
            //int[,] matrixOne =
            //{
            //    { 1, 0, 1 },
            //    { 0, 2, 2 },
            //    { 1, 2, 5 }
            //};

            //Console.WriteLine(isSymmetric(matrixOne));

            //int[,] matrixTwo =
            //{
            //    { 7, 7, 7 },
            //    { 6, 5, 7 },
            //    { 1, 2, 1 }
            //};

            //Console.WriteLine(isSymmetric(matrixTwo));

        }

        public static bool isSymmetric(int[,] matrix)
        {
            int falseValue = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    if (matrix[i, j] != matrix[j, i])
                    {
                        falseValue++;
                    }
                }
            }

            if (falseValue > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}

//Create a function named isSymmetric that takes an n×n integer matrix (two dimensional array/list) as a parameter and returns true if the matrix is symmetric or false if it is not.

//Symmetric means it has identical values along its diagonal axis from top-left to bottom-right, as in the first example.