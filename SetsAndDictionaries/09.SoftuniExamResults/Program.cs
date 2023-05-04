using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.SoftuniExamResults
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> studentsScore = new Dictionary<string, int>();
            Dictionary<string,int> languagesSubmission = new Dictionary<string, int>();

            string input = Console.ReadLine();

            while (input != "exam finished")
            {
                string[] tockens = input.Split("-", StringSplitOptions.RemoveEmptyEntries);
                string currName = tockens[0];

                if (tockens[1] == "banned")
                {
                    if (studentsScore.ContainsKey(currName))
                    {
                        studentsScore.Remove(currName);
                    }
                    input = Console.ReadLine();
                    continue;
                }
                else
                {
                    string language = tockens[1];
                    int score = int.Parse(tockens[2]);
                    if (!languagesSubmission.ContainsKey(language))
                    {
                        languagesSubmission.Add(language, 0);
                    }
                    languagesSubmission[language] ++;
                    if (!studentsScore.ContainsKey(currName))
                    {
                        studentsScore.Add(currName, score);
                    }
                    else
                    {
                        if (studentsScore[currName] < score)
                        {
                            studentsScore[currName] = score;
                        }
                    }

                }
                input = Console.ReadLine();
            }
            Dictionary<string,int> orderedStudents = studentsScore.OrderByDescending(o => o.Value).ThenBy(o => o.Key).ToDictionary(o => o.Key, o => o.Value);
            Console.WriteLine("Results:");
            foreach (var item in orderedStudents)
            {
                string student = item.Key;
                int points = item.Value;
                Console.WriteLine($"{student} | {points}");
            }
            Console.WriteLine("Submissions:");
            Dictionary<string,int> orderedLanguages = languagesSubmission.OrderByDescending(o => o.Value).ThenBy(o => o.Key).ToDictionary(o => o.Key, o => o.Value);
            foreach (var item in orderedLanguages)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
        }
    }
}
