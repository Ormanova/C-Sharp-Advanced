using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.KnightGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            if (size < 3)
            {
                Console.WriteLine(0);
                return;
            }
            char[,] matrix = new char[size, size];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string input = Console.ReadLine();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = input[col];
                }
            }
            Dictionary<int[], int> listOfAttackKnights = new Dictionary<int[], int>();

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == 'K')
                    {
                        int[] attackedKnightPosition = new int[2];
                        attackedKnightPosition[0] = row;
                        attackedKnightPosition[1] = col;
                        int attacks = 0;
                        //if (row - 2 >= 0 && row - 2 < matrix.GetLength(0) && col + 1 >= 0 && col + 1 < matrix.GetLength(1))
                        if (IsValid(matrix,row,col))
                        {
                            if (matrix[row, col] == matrix[row - 2, col + 1])
                            {
                                attackedKnightPosition[0] = row;
                                attackedKnightPosition[1] = col;
                                attacks++;
                                if (!listOfAttackKnights.ContainsKey(attackedKnightPosition))
                                {
                                    listOfAttackKnights.Add(attackedKnightPosition, attacks);

                                }
                                else
                                {
                                    listOfAttackKnights[attackedKnightPosition] += 1;
                                }

                            }

                        }
                        //if (row - 1 >= 0 && row - 1 < matrix.GetLength(0) && col + 2 >= 0 && col + 2 < matrix.GetLength(1))
                        if(IsValid(matrix,row,col))
                        {
                            if (matrix[row, col] == matrix[row - 1, col + 2])
                            {
                                attackedKnightPosition[0] = row;
                                attackedKnightPosition[1] = col;
                                attacks++;
                                if (!listOfAttackKnights.ContainsKey(attackedKnightPosition))
                                {
                                    listOfAttackKnights.Add(attackedKnightPosition, attacks);

                                }
                                else
                                {
                                    listOfAttackKnights[attackedKnightPosition] += 1;
                                }

                            }

                        }
                        //if (row + 1 >= 0 && row + 1 < matrix.GetLength(0) && col + 2 >= 0 && col + 2 < matrix.GetLength(1))
                        if(IsValid(matrix,row,col))
                        {
                            if (matrix[row, col] == matrix[row + 1, col + 2])
                            {
                                attackedKnightPosition[0] = row;
                                attackedKnightPosition[1] = col;
                                attacks++;
                                if (!listOfAttackKnights.ContainsKey(attackedKnightPosition))
                                {
                                    listOfAttackKnights.Add(attackedKnightPosition, attacks);

                                }
                                else
                                {
                                    listOfAttackKnights[attackedKnightPosition] += 1;
                                }

                            }

                        }
                        //if (row + 2 >= 0 && row + 2 < matrix.GetLength(0) && col + 1 >= 0 && col + 1 < matrix.GetLength(1))
                            if (IsValid(matrix, row, col))
                            {
                            if (matrix[row, col] == matrix[row + 2, col + 1])
                            {
                                attackedKnightPosition[0] = row;
                                attackedKnightPosition[1] = col;
                                attacks++;
                                if (!listOfAttackKnights.ContainsKey(attackedKnightPosition))
                                {
                                    listOfAttackKnights.Add(attackedKnightPosition, attacks);

                                }
                                else
                                {
                                    listOfAttackKnights[attackedKnightPosition] += 1;
                                }

                            }

                        }
                        //if (row + 2 >= 0 && row + 2 < matrix.GetLength(0) && col - 1 >= 0 && col - 1 < matrix.GetLength(1))
                        if (IsValid(matrix, row, col))
                        {
                            if (matrix[row, col] == matrix[row + 2, col - 1])
                            {
                                attackedKnightPosition[0] = row;
                                attackedKnightPosition[1] = col;
                                attacks++;
                                if (!listOfAttackKnights.ContainsKey(attackedKnightPosition))
                                {
                                    listOfAttackKnights.Add(attackedKnightPosition, attacks);

                                }
                                else
                                {
                                    listOfAttackKnights[attackedKnightPosition] += 1;
                                }

                            }

                        }
                        //if (row + 1 >= 0 && row + 1 < matrix.GetLength(0) && col - 2 >= 0 && col - 2 < matrix.GetLength(1))
                        if (IsValid(matrix, row, col))
                        {
                            if (matrix[row, col] == matrix[row + 1, col - 2])
                            {
                                attackedKnightPosition[0] = row;
                                attackedKnightPosition[1] = col;
                                attacks++;
                                if (!listOfAttackKnights.ContainsKey(attackedKnightPosition))
                                {
                                    listOfAttackKnights.Add(attackedKnightPosition, attacks);

                                }
                                else
                                {
                                    listOfAttackKnights[attackedKnightPosition] += 1;
                                }

                            }

                        }
                        //if (row - 1 >= 0 && row - 1 < matrix.GetLength(0) && col - 2 >= 0 && col - 2 < matrix.GetLength(1))
                        if (IsValid(matrix, row, col))
                        {
                            if (matrix[row, col] == matrix[row - 1, col - 2])
                            {
                                attackedKnightPosition[0] = row;
                                attackedKnightPosition[1] = col;
                                attacks++;
                                if (!listOfAttackKnights.ContainsKey(attackedKnightPosition))
                                {
                                    listOfAttackKnights.Add(attackedKnightPosition, attacks);

                                }
                                else
                                {
                                    listOfAttackKnights[attackedKnightPosition] += 1;
                                }

                            }
                        }
                        //if (row - 2 >= 0 && row - 2 < matrix.GetLength(0) && col - 1 >= 0 && col - 1 < matrix.GetLength(1))
                        if (IsValid(matrix, row, col))
                        {
                            if (matrix[row, col] == matrix[row - 2, col - 1])
                            {
                                attackedKnightPosition[0] = row;
                                attackedKnightPosition[1] = col;
                                attacks++;
                                if (!listOfAttackKnights.ContainsKey(attackedKnightPosition))
                                {
                                    listOfAttackKnights.Add(attackedKnightPosition, attacks);

                                }
                                else
                                {
                                    listOfAttackKnights[attackedKnightPosition] += 1;
                                }

                            }
                        }
                    }
                }
            }
            if (listOfAttackKnights.Count == 0)
            {
                Console.WriteLine("0");
            }
            else
            {
                int bestValue = 0;
                int[] bestPosition = new int[2];
                foreach (var item in listOfAttackKnights)
                {
                    int[] position = item.Key;
                    int value = item.Value;
                    if (value > bestValue)
                    {
                        bestValue = value;
                        bestPosition = position;
                    }
                }
                matrix[bestPosition[0], bestPosition[1]] = 'O';
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {

                    }
                }
            }



        }


        private static int IsMatch(char[,] matrix, int row, int col, int attacks)
        {
            return attacks;
        }

        private static bool IsValid(char[,] matrix, int row, int col)
        {
            return (
                 (row - 2 >= 0 && row - 2 < matrix.GetLength(0) && col + 1 >= 0 && col + 1 < matrix.GetLength(1))
                || (row - 1 >= 0 && row - 1 < matrix.GetLength(0) && col + 2 >= 0 && col + 2 < matrix.GetLength(1))
                || (row + 1 >= 0 && row + 1 < matrix.GetLength(0) && col + 2 >= 0 && col + 2 < matrix.GetLength(1)) 
                || (row + 2 >= 0 && row + 2 < matrix.GetLength(0) && col + 1 >= 0 && col + 1 < matrix.GetLength(1)) 
                || (row + 2 >= 0 && row + 2 < matrix.GetLength(0) && col - 1 >= 0 && col - 1 < matrix.GetLength(1))
                || (row + 1 >= 0 && row + 1 < matrix.GetLength(0) && col - 2 >= 0 && col - 2 < matrix.GetLength(1))
                || (row - 1 >= 0 && row - 1 < matrix.GetLength(0) && col - 2 >= 0 && col - 2 < matrix.GetLength(1))
                || (row - 2 >= 0 && row - 2 < matrix.GetLength(0) && col - 1 >= 0 && col - 1 < matrix.GetLength(1)));
        }
    }
}


