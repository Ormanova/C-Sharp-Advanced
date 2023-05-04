using System;
using System.Collections.Generic;

namespace _01.UniqueUsernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberUsernames = int.Parse(Console.ReadLine());

            HashSet<string> set = new HashSet<string>();

            for (int i = 0; i < numberUsernames; i++)
            {
                string input = Console.ReadLine();
                set.Add(input);
            }
            Console.WriteLine(string.Join(System.Environment.NewLine,set));
        }
    }
}
