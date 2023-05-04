using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.StackSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < numbers.Length; i++)
            {
                stack.Push(numbers[i]);
            }
            string comand = Console.ReadLine().ToLower();
            while (comand != "end")
            {
                string[] splittedComand = comand.Split(" ");
                if (splittedComand[0] == "add" )
                {
                    int n1 = int.Parse(splittedComand[1]);
                    int n2 = int.Parse((splittedComand[2]));
                    stack.Push(n1);
                    stack.Push(n2);
                }
                if (splittedComand[0] == "remove")
                {
                    int numbersToRemove = int.Parse(splittedComand[1]);
                    if (stack.Count< numbersToRemove)
                    {
                        comand = Console.ReadLine().ToLower();
                        continue; 
                    }
                    else
                    {
                        for (int i = 0; i < numbersToRemove; i++)
                        {
                            stack.Pop();
                        }
                    }
                }

                comand = Console.ReadLine().ToLower();
            }
            Console.WriteLine("Sum:" + " " + stack.Sum());
        }
    }
}
