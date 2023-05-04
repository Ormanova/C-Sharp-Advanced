using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.SimpleCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ").ToArray();

            Stack<string> stack = new Stack<string>();
            
            for (int i = input.Length - 1; i >= 0; i--)
            {
                string tocken = input[i];
                stack.Push(tocken);
            }
            int lastNumber = int.Parse(stack.Pop());
            int result = lastNumber;
            while (stack.Count > 0)
            {

                if (stack.Peek() == "+")
                {
                    stack.Pop();
                    result += int.Parse(stack.Pop());
                    continue;

                }
                if (stack.Peek() == "-")
                {
                    stack.Pop();
                    result -= int.Parse(stack.Pop());
                    continue;
                }
            }
            Console.WriteLine(result);
        }
    }
}
