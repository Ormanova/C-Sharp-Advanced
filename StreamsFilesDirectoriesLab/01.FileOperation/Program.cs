using System;
using System.IO;

namespace _01.FileOperation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (reader)
            {

            }
            StreamReader reader = new StreamReader("../../../input.txt");
            string input = reader.ReadToEnd();

            reader.Close();
            Console.WriteLine(input);
        }
    }
}
