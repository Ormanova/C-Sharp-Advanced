using System;
using System.Linq;

namespace _06.JaggedArrayManipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            int[][] matrix = new int[rows][];
            for (int row = 0; row < rows; row++)
            {
                int[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                matrix[row] = input;
            }
            for (int row = 0; row < rows - 1; row++)
            {
                if (matrix[row].Length == matrix[row + 1].Length)
                {
                    for (int i = 0; i < matrix[row].Length; i++)
                    {
                        matrix[row][i] *= 2;
                        matrix[row + 1][i] *= 2;
                    }
                }
                else
                {
                    for (int i = 0; i < matrix[row].Length; i++)
                    {
                        matrix[row][i] /= 2;

                    }
                    for (int j = 0; j < matrix[row + 1].Length; j++)
                    {
                        matrix[row + 1][j] /= 2;
                    }
                }
            }
            string comand = Console.ReadLine();
            while (comand != "End")
            {
                string[] tockens = comand.Split(" ").ToArray();
                int row = int.Parse(tockens[1]);
                int col = int.Parse(tockens[2]);
                int value = int.Parse(tockens[3]);
                if (tockens[0] == "Add")
                {
                    if (IsValid(row, col, matrix))
                    {
                        matrix[row][col] += value;
                    }
                    else
                    {
                        comand = Console.ReadLine();
                        continue;
                    }
                }
                else if (tockens[0] == "Subtract")
                {
                    if (IsValid(row,col,matrix))
                    {
                        matrix[row][col] -= value;
                    }
                    else
                    {
                        comand = Console.ReadLine();
                        continue;
                    }
                }
                comand = Console.ReadLine();
            }
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    Console.Write(matrix[row][col] + " ");
                }
                Console.WriteLine();
            }
        }

        private static bool IsValid(int row, int col, int[][] matrix)
        {

            return (row >= 0 && col >= 0 && row < matrix.Length && col < matrix[row].Length);
        }
    }
}
