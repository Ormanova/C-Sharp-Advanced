using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.PeriodicTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            HashSet<string> set = new HashSet<string>();
            for (int j = 0; j < n; j++)
            {
                string[] input = Console.ReadLine().Split(' ');
                for (int i = 0; i < input.Length; i++)
                {
                        set.Add(input[i]);
                }
            }
            HashSet<string> setOrdered = set.OrderByDescending(x => x).ToHashSet();
            HashSet<string> ordered = setOrdered.Reverse().ToHashSet();
            Console.WriteLine(string.Join(" ",ordered));

        }
    }
}
