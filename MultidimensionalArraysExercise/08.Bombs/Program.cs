using System;
using System.Linq;

namespace _08.Bombs
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int  dimensions = int.Parse(Console.ReadLine());

            int[,] matrix = new int[dimensions,dimensions];

            for (int row = 0; row < dimensions; row++)
            {
                int[] input = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int col = 0; col < dimensions; col++)
                {
                    matrix[row,col ] = input[col];
                }
            }
            string[] input2 = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).ToArray();
            foreach (var item in input2)
            {
                int[] indices = item.Split(",", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                int row = indices[0];
                int col = indices[1];
                Explode(row, col,matrix);

            }
            int aliveCells = 0;
            int sum = 0;

            for (int row = 0; row < dimensions; row++)
            {
                for (int col = 0; col < dimensions; col++)
                {
                    if (matrix[row, col] > 0)
                    {
                        aliveCells++;
                        sum += matrix[row, col];
                    }
                }
            }

            Console.WriteLine($"Alive cells: {aliveCells}");
            Console.WriteLine($"Sum: {sum}");
            for (int row = 0; row < dimensions; row++)
            {
                for (int col = 0; col < dimensions; col++)
                {
                    Console.Write($"{matrix[row, col]} ");
                }

                Console.WriteLine();
            }
        }

        private static void Explode(int row, int col, int[,] matrix)
        {
            int value = matrix[row, col];
            if (value > 0)
            {
                matrix[row, col] = 0;
                if (row>0 && matrix[row - 1,col] > 0)
                {
                    matrix[row - 1, col] -= value;
                }
                if (row > 0 && col < matrix.GetLength(1) - 1 && matrix[row - 1,col + 1] > 0)
                {
                    matrix[row - 1, col + 1] -= value;
                }
                if (col < matrix.GetLength(1) - 1 && matrix[row, col + 1 ] > 0)
                {
                    matrix[row, col + 1] -= value;
                }
                if (row< matrix.GetLength(0) - 1 && col < matrix.GetLength(1) - 1 && matrix[row + 1, col + 1] > 0)
                {
                    matrix[row + 1, col + 1] -= value;
                }
                if (row < matrix.GetLength(0) - 1 && matrix[row +1, col] > 0)
                {
                    matrix[row + 1, col] -= value;
                }
                if (row < matrix.GetLength(0) - 1 && col > 0 && matrix[row + 1, col -1]> 0)
                {
                    matrix[row + 1, col - 1] -= value;
                }
                if (col> 0 && matrix[row,col - 1] > 0)
                {
                    matrix[row, col - 1] -= value;
                }
                if (row > 0 && col > 0 && matrix[row - 1, col - 1]> 0)
                {
                    matrix[row - 1, col - 1] -= value;
                }
            }
        }
    }
}
