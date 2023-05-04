using System;
using System.Linq;

namespace _06.JaggedArrayModification
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int[][] jagged = new int[rows][];
            for (
                int row = 0; row < jagged.Length; row++)
            {
                int[] input = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                jagged[row] = input;
            }
            string[] comand = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
            while (comand[0] != "END")
            {
                if (comand[0] == "Add")
                {
                    //Add {row} {col} {value} – Increase the number at the given coordinates with the value.
                    int row = int.Parse(comand[1]);
                    int col = int.Parse(comand[2]);
                    int value = int.Parse(comand[3]);
                    if (row < 0 || row >= jagged.Length || col < 0 || col >= jagged[row].Length)
                    {
                        Console.WriteLine("Invalid coordinates");
                        comand = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                        continue;
                    }
                    jagged[row][col] += value;
                }
                else if (comand[0]== "Subtract")
                {
                    //Subtract {row} {col} {value} – Decrease the number at the given coordinates by the value.
                    int row = int.Parse(comand[1]);
                    int col = int.Parse(comand[2]);
                    int value = int.Parse(comand[3]);
                    if (row < 0 || row >= jagged.Length || col < 0 || col >= jagged[row].Length)
                    {
                        Console.WriteLine("Invalid coordinates");
                        comand = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                        continue;
                    }
                    jagged[row][col] -= value;
                }
                comand = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }
            for (int row = 0; row < jagged.Length; row++)
            {
                for (int col = 0; col < jagged[row].Length; col++)
                {
                    Console.Write($"{jagged[row][col]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
