using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.Ranking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> contestPass = new Dictionary<string, string>();
            Dictionary<string, Dictionary<string, int>> score = new Dictionary<string, Dictionary<string, int>>();
            string input = Console.ReadLine();
            while (input != "end of contests")
            {
                string[] tockens = input.Split(":", StringSplitOptions.RemoveEmptyEntries);
                string contest = tockens[0];
                string password = tockens[1];
                if (!contestPass.ContainsKey(contest))
                {
                    contestPass.Add(contest, password);

                }
                else
                {
                    contestPass.Add(contest, password);
                }
                input = Console.ReadLine();
            }
            string input2 = Console.ReadLine();
            while (input2 != "end of submissions")
            {
                string[] tockens = input2.Split("=>", StringSplitOptions.RemoveEmptyEntries);
                string currentContest = tockens[0];
                string currentPassword = tockens[1];
                string username = tockens[2];
                int currPoints = int.Parse(tockens[3]);
                if (IsValid(contestPass, currentContest, currentPassword))
                {
                    if (score.ContainsKey(username))
                    {
                        if (score[username].ContainsKey(currentContest))
                        {
                            if (score[username][currentContest] < currPoints)
                            {
                                score[username][currentContest] = currPoints;
                            }

                        }
                        else
                        {
                            score[username][currentContest] = currPoints;
                        }

                    }
                    else
                    {
                        score.Add(username, new Dictionary<string, int>());
                        score[username][currentContest] = currPoints;
                    }
                }

                input2 = Console.ReadLine();
            }
            Dictionary<string, Dictionary<string, int>> orderedScore = score.OrderBy(s => s.Key).ToDictionary(s => s.Key,s => s.Value);
            
            string bestName = "";
            int bestScore = 0;
            foreach (var name in score)
            {
                string currentnName = name.Key;
                Dictionary<string,int> contestPoints = score[name.Key].OrderByDescending(s => s.Value).ToDictionary(s => s.Key, s => s.Value);
                int points = contestPoints.Values.Sum();
                if (points > bestScore)
                {
                    bestScore = points;
                    bestName = currentnName;
                }
             
            }
            Console.WriteLine($"Best candidate is {bestName} with total {bestScore} points.");
            Console.WriteLine("Ranking:");
            foreach (var item in orderedScore)
            {
                string username = item.Key;
                Dictionary<string,int> contestsPoints = item.Value;
                Dictionary<string, int> ordered = contestsPoints.OrderByDescending(s => s.Value).ToDictionary(s => s.Key, s => s.Value);
                Console.WriteLine(username);
                foreach (var element in ordered)
                {
                    
                    Console.Write($"#  {element.Key} -> {element.Value}");
                    Console.WriteLine();
                }
                
                //Console.WriteLine(username);
                //Console.Write(string.Join(System.Environment.NewLine, contestsPoints));
                //Console.WriteLine();
            }
        }

        private static bool IsValid(Dictionary<string, string> contestPass, string currentContest, string currentPassword)
        {
            if (contestPass.ContainsKey(currentContest))
            {
                if (contestPass[currentContest] == currentPassword)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
