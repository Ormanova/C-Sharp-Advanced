using System;
using System.Linq;

namespace _04.MatrixShuffling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] dimensions = Console.ReadLine().Split(" ");
            int rows = int.Parse(dimensions[0]);
            int cols = int.Parse(dimensions[1]);
            string[,] matrix = new string[rows, cols];

            ReadMatrix(matrix);
            string comands = Console.ReadLine();
            while (comands != "END")
            {
                string[] comandArg = comands.Split(" ",StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (comandArg[0] == "swap")
                {
                    int row1 = int.Parse(comandArg[1]);
                    int col1 = int.Parse(comandArg[2]);
                    int row2 = int.Parse(comandArg[3]);
                    int col2 = int.Parse(comandArg[4]);

                    //IsValid(matrix, row1, col1, row2, col2))
                    if (row1 >= 0 && row1 < matrix.GetLength(0) && row2 >= 0 && row2 < matrix.GetLength(0) && col1 >= 0 && col2 >= 0 && col1 < matrix.GetLength(1) && col2 < matrix.GetLength(1))                                                                 
                    {
                        string elementForMoving = matrix[row2, col2];
                        matrix[row2, col2] = matrix[row1, col1];
                        matrix[row1, col1] = elementForMoving;
                        PrintMatrix(matrix);
                        
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                        comands = Console.ReadLine();
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                    comands = Console.ReadLine();
                    continue;
                }

                comands = Console.ReadLine();
            }
        }

        private static bool IsValid(string[,] matrix, int row1, int col1, int row2, int col2)
        {
            if (row1 > 0 && row1< matrix.GetLength(0) && row2 > 0 && row2 < matrix.GetLength(0) && col1 > 0 && col2 > 0 && col1 < matrix.GetLength(1) && col2 < matrix.GetLength(1))
            {
                return true;
            }
            return false;
        }

        private static void PrintMatrix(string[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row,col] + " "); ;
                }
                Console.WriteLine();
            }
        }

        private static void ReadMatrix(string[,] matrix)
        {
           for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] input = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = input[col];
                }
            }
        }
    }
}
