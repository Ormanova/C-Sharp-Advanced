using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.ForceBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, HashSet<string>> forceBook = new Dictionary<string, HashSet<string>>();

            string input = Console.ReadLine();
            while (input != "Lumpawaroo")
            {
                if (input.Contains("|"))
                {
                //If you receive forceSide | forceUser, you should check if such forceUser already exists, and if not, add him/ her to the corresponding side.
                string[] tockens = input.Split('|');
                    string forceSide = tockens[0];
                    string forceUser = tockens[1];
                    forceBook.Add(forceSide, new HashSet<string>());
                    forceBook[forceSide].Add(forceUser);
                }
                else if (input.Contains("->"))
                {
                    //    If you receive a forceUser->forceSide, you should check if there is such a forceUser already and if so, change his/ her side.If there is no such forceUser, add him/ her to the corresponding forceSide, treating the command as a newly registered forceUser.
                    string[] tockens = input.Split("->");
                    string forceUser = tockens[0];
                    string forceSide = tockens[1];

                    foreach (var item in forceBook)
                    {
                        string currentForceSide = item.Key;
                        HashSet<string> currentForceUsers = item.Value;
                        foreach (var user in currentForceUsers)
                        {
                            if (currentForceUsers == forceUser)
                            {

                            }
                        }
                    }
                }   
            }

        }

    }
}

