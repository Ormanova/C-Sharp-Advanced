using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.CountSymbols
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<char,int> collection = new Dictionary<char,int>();

            for (int i = 0; i < input.Length; i++)
            {
                char c = input[i];
                if (!collection.ContainsKey(c))
                {
                    collection.Add(c, 0);
                }
                collection[c]++;
            }
            collection = collection.OrderByDescending(pair => pair.Key).ToDictionary(pair => pair.Key, pair => pair.Value);
            Dictionary<char, int> ordered = collection.Reverse().ToDictionary(pair=>pair.Key, pair => pair.Value);
            foreach (var item in ordered)
            {
                char c = item.Key;
                int count = item.Value;
                Console.WriteLine($"{c}: {count} time/s");
            }
        }
    }
}
