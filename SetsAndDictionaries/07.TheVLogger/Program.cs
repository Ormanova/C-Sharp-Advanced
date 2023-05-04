using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.TheVLogger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<HashSet<string>, Dictionary<string, int>> vloggersFollowers =  new Dictionary<HashSet<string>, Dictionary<string, int>>(); 
            string[] input = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries);
            
            while (input[0] != "Statistics")
            {
                string vlogger1 = input[0];
                if (input[1] == "joined")
                {
                    //"{vloggername}" joined The V - Logger – keep the vlogger in your records.
                    //Vloggernames consist of only one word.
                    //If the given vloggername already exists, ignore that command.
                    vloggersFollowers.Add(new HashSet<string>(), new Dictionary<string, int>()) { vlogger1 , null , 0};
                    
                   
                }
                else if (input[1] == "followed")
                {
                    //"{vloggername} followed {vloggername}" – The first vlogger followed the second vlogger.
                    //If any of the given vlogernames does not exist in your collection, ignore that command.
                    //Vlogger cannot follow himself.
                    //Vloggers cannot follow someone he is already a follower of.
                    string vlogger2 = input[2];
                    if (!vloggersFollowers.ContainsKey(vlogger1))
                    {
                        input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                        continue;
                    }
                    else
                    {
                        if (vlogger1 == vlogger2)
                        {
                            input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                            continue;
                        }
                        else
                        {
                            vloggersFollowers[vlogger2].Add(vlogger1);
                            countFollowings[vlogger1] += 1;
                        }
                    }
                }
                input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            }
            
            Console.WriteLine($"The V-Logger has a total of {vloggersFollowers.Count} vloggers in its logs.");

        }
    }
}
