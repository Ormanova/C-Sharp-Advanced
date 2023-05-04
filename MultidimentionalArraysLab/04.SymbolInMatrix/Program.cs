using System;

namespace _04.SymbolInMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int matrixDimensions = int.Parse(Console.ReadLine());

            int rows = matrixDimensions;
            int cols = matrixDimensions;

            char[,] matrix = new char[rows, cols];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string input = Console.ReadLine();
                 char[] data = input.ToCharArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = data[col];
                }
            }
            char c = char.Parse(Console.ReadLine());
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    char currentElement = matrix[row, col];
                    if (currentElement == c)
                    {
                        Console.WriteLine($"({row}, {col})");
                        return;
                    }
                }
            }
            Console.WriteLine($"{c} does not occur in the matrix");
        }
    }
}
