using System;
using System.Collections.Generic;

namespace _06.SuperMarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> queue = new Queue<string>();
            string name = Console.ReadLine();
            while (name != "End")
            {
                if (name == "Paid")
                {
                    if (queue.Count > 0)
                    {
                        int countQueue = queue.Count;
                        for (int i = 0; i < countQueue; i++)
                        {
                            Console.WriteLine(queue.Dequeue());
                        }
                    }
                    name = Console.ReadLine();
                    continue;
                }
                queue.Enqueue(name);

                name = Console.ReadLine();
            }
            Console.WriteLine($"{queue.Count} people remaining.");
        }
    }
}
