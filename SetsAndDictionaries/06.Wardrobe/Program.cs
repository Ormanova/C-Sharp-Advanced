using System;
using System.Collections.Generic;

namespace _06.Wardrobe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nLines = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, int>> clothes = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < nLines; i++)
            {
                string[] input = Console.ReadLine().Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
                string colour = input[0];
                string[] typeOfClothes = input[1].Split(",", StringSplitOptions.RemoveEmptyEntries);

                if (!clothes.ContainsKey(colour))
                {
                    clothes.Add(colour, new Dictionary<string, int>());
                    for (int j = 0; j < typeOfClothes.Length; j++)
                    {
                        string type = typeOfClothes[j];
                        if (!clothes[colour].ContainsKey(typeOfClothes[j]))
                        {
                            clothes[colour].Add(type, 0);
                        }
                        clothes[colour][type]++;
                    }
                }
                else
                {
                    for (int j = 0; j < typeOfClothes.Length; j++)
                    {
                        string type = typeOfClothes[j];
                        if (!clothes[colour].ContainsKey(typeOfClothes[j]))
                        {
                            clothes[colour].Add(type, 0);
                        }
                        clothes[colour][type]++;
                    }
                }


            }
            string[] desiredClothes = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string desiredColour = desiredClothes[0];
            string desiredType = desiredClothes[1];

            foreach (var item in clothes)
            {
                string currentColour = item.Key;
                Dictionary<string, int> currentTypeClothes = item.Value;

                Console.WriteLine($"{currentColour} clothes:");
                foreach (var type in currentTypeClothes)
                {
                    string typeCloth = type.Key;
                    int count = type.Value;
                    if (currentColour == desiredColour && typeCloth == desiredType) 
                    {
                        Console.WriteLine($"* {typeCloth} - {count} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {typeCloth} - {count}");
                    }
                }
            }
        }
    }
}
