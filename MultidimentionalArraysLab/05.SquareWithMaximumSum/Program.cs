using System;
using System.Linq;

namespace _05.SquareWithMaximumSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int rows = dimensions[0];
            int cols = dimensions[1];
            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = input[col];
                }
            }
            int bestSum = 0;
            int bestRowIndex = -1;
            int bestcolIndex = -1;

            for (int row = 0;row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    int currentSum = matrix[row, col] + matrix[row + 1, col] + matrix[row, col + 1] + matrix[row + 1, col + 1];
                    if (currentSum > bestSum)
                    {
                        bestSum = currentSum;
                        bestRowIndex = row;
                        bestcolIndex = col;
                    }
                }
            }
            for (int row = bestRowIndex; row < bestRowIndex + 2; row++)
            {
                for (int col = bestcolIndex; col < bestcolIndex + 2; col++)
                {
                    Console.Write(matrix[row,col] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine(bestSum);
            //PrintMatrix(matrix);
        }
        public static void PrintMatrix ( int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row,col] + " ");
                }
                Console.WriteLine();
            }
            
        }
        
    }
    
}
