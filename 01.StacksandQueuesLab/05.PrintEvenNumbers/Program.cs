using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.PrintEvenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Queue<int> queue = new Queue<int>();
            Queue<int> evenNumbers = new Queue<int>();
            for (int i = 0; i < numbers.Length; i++)
            {
                queue.Enqueue(numbers[i]);
            }
            foreach (var item in queue)
            {
                if (item % 2 == 0)
                {
                    evenNumbers.Enqueue(item);
                }
            }
            int[] output = evenNumbers.ToArray();
            Console.WriteLine(String.Join(", ",output));
        }
    }
}
