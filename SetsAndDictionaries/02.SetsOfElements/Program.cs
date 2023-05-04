using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.SetsOfElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int n = numbers[0];
            int m = numbers[1];

            HashSet<int> set1 = new HashSet<int>();
            HashSet<int> set2 = new HashSet<int>();
            HashSet<int> matched = new HashSet<int>();


            for (
                int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                set1.Add(number);
            }
            for (int j = 0; j < m; j++)
            {
                int number = int.Parse(Console.ReadLine());
                set2.Add(number);
            }
            int biggerCount = set2.Count();
            if (set2.Count < set1.Count)
            {
                foreach (var item in set2)
                {
                    int currentElement = item;
                    if (set1.Contains(item))
                    {
                        matched.Add(currentElement);
                    }
                }
            }
            else
            {
                foreach (var item in set1)
                {
                    int currEl = item;
                    if (set2.Contains(item))
                    {
                        matched.Add(currEl);
                    }
                }
            }
            Console.WriteLine(String.Join(" ",matched));
        }
    }
}
