using System;
using System.Linq;

namespace _02.SumMatrixColumns
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

                int[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = input[col];

                }
                
            }


            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                int sumCol = 0;
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    sumCol += matrix[row, col];
                }
                Console.WriteLine(sumCol);
            }
            Console.WriteLine();


        }
    }
}
