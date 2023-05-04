using System;
using System.Collections.Generic;

namespace _04.EvenTimes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<int, int> integers = new Dictionary<int, int>();

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (!integers.ContainsKey(number))
                {
                    integers.Add(number,0);
                }
                
                    integers[number]++;
                

            }

            foreach (var item in integers)
            {
            
                int number = item.Key;
                int count = item.Value;
                if (count % 2 == 0)
                {
                    Console.WriteLine(number);
                }
            }
        }
    }
}
