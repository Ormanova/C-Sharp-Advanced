using System;

namespace _05.SnakeMoves
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] dimensions = Console.ReadLine().Split(" ");
            int rows = int.Parse(dimensions[0]);
            int cols = int.Parse(dimensions[1]);
            char[,] matrix = new char[rows, cols];
            string input = Console.ReadLine();
            int index = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                if (row % 2 == 0)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        if (index == input.Length)
                        {
                            index = 0;
                        }
                        matrix[row, col] = input[index];
                        index++;
                    }
                }
                else
                {
                    for (int col = matrix.GetLength(1) - 1; col >= 0; col--)
                    {
                        if (index == input.Length)
                        {
                            index = 0;
                        }
                        matrix[row, col] = input[index];
                        index++;
                    }
                }

            }
            PrintMatrix(matrix);
        }
        private static void PrintMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]); ;
                }
                Console.WriteLine();
            }
        }
    }
}
