using System;
using System.Linq;

namespace _03.PrimaryDiagonal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int matrixDimensions = int.Parse(Console.ReadLine());

            int rows = matrixDimensions;
            int cols = matrixDimensions;
            int[,] matrix = new int[rows, cols];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] input = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = input[col];
                }
            }

            int sumPrimaryDiagonal = 0;
            int sumSecondaryDiagonal = 0;   
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                sumPrimaryDiagonal += matrix[row, row];
            }
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                sumSecondaryDiagonal += matrix[row, cols - row - 1];
            }
            Console.WriteLine(sumPrimaryDiagonal);
        }
    }
}
