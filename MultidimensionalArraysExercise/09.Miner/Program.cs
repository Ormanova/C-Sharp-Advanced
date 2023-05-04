using System;
using System.Linq;

namespace _09.Miner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            string[] comands = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            char[,] matrix = new char[size, size];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] rowsInput = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowsInput[col];
                }
            }
            int rowStart = 0;
            int columnStart = 0;
            int maxCoals = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == 's')
                    {
                        rowStart = row;
                        columnStart = col;
                    }
                    if (matrix[row, col] == 'c')
                    {
                        maxCoals++;
                    }
                }
            }
            int lastRowCoalIndex = 0;
            int lastColumnCoalIndex = 0;
            for (int i = 0; i < comands.Length; i++)
            {
                string currentComand = comands[i];
                int nextRow = 0;
                int nextCol = 0;
                if (currentComand == "left")
                {
                     nextCol = -1;
                    
                }
                else if (currentComand == "right")
                {
                    nextCol = 1;
                    
                }
                else if (currentComand == "up")
                {
                    nextRow = - 1;
                    
                }
                else if (currentComand == "down")
                {
                    nextRow = 1;
                    
                }
                if (!IsRange(matrix,rowStart + nextRow,columnStart + nextCol))
                {
                    continue;
                }
                rowStart += nextRow;
                columnStart += nextCol;
                if (matrix[rowStart, columnStart] == 'c')
                {
                    maxCoals--;
                    lastRowCoalIndex = rowStart;

                    lastColumnCoalIndex = columnStart;
                    matrix[rowStart, columnStart] = '*';
                    if (maxCoals == 0)
                    {
                        Console.WriteLine($"You collected all coals! ({rowStart}, {columnStart})");
                        return;
                    }
                }
                else if (matrix[rowStart, columnStart] == 'e')
                {
                    Console.WriteLine($"Game over! ({rowStart}, {columnStart})");
                    return;
                }
            }
            
                Console.WriteLine($"{maxCoals} coals left. ({rowStart}, {columnStart})");
            
        }

        private static bool IsRange( char[,] matrix, int row, int col)
        {
            return row >= 0 && row < matrix.GetLength(0) && col >= 0 && col < matrix.GetLength(1);
        }
    }
}
