using System;
using System.Collections.Generic;

namespace _04.MatchingBrackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Stack<int> openBracketIndexes = new Stack<int>();

            for (int i = 0; i < input.Length; i++)
            {
                char c = input[i];
                if (c == '(')
                {
                    openBracketIndexes.Push(i);
                }
                else if (c == ')')
                {
                    int openIndex = openBracketIndexes.Pop();
                    for (int j = openIndex; j <= i; j++)
                    {
                        Console.Write(input[j]);
                    }
                    Console.WriteLine();
                }

            }
        }
    }
}
