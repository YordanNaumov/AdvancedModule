using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.The_V_Logger
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] commands = Console.ReadLine()
                .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            
            //vlogerUsername - number of followers[0] - number of followedVloggers[1]
            var vloggers = new Dictionary<string, int[]>();
          
            //vlogerUsername - list of followers
            var vloggersAndFollowers = new Dictionary<string, List<string>>();

            while (commands[0] != "Statistics")
            {
                if (commands[1] == "joined")
                {
                    string vloggerName = commands[0];

                    if (!vloggers.ContainsKey(vloggerName))
                    {
                        vloggers[vloggerName] = new int[2];
                        vloggersAndFollowers[vloggerName] = new List<string>();
                    }
                }
                else if (commands[1] == "followed")
                {
                    string follower = commands[0];
                    string followedVlogger = commands[2];

                    if (vloggers.ContainsKey(follower) && vloggers.ContainsKey(followedVlogger) 
                        && follower != followedVlogger && !vloggersAndFollowers[followedVlogger].Contains(follower))
                    {
                        vloggers[followedVlogger][0]++;
                        vloggersAndFollowers[followedVlogger].Add(follower);

                        vloggers[follower][1]++;
                    }
                }

                commands = Console.ReadLine()
                .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            }

            Console.WriteLine($"The V-Logger has a total of {vloggers.Count} vloggers in its logs.");

            vloggers = vloggers.OrderByDescending(x => x.Value[0])
                .ThenBy(x => x.Value[1])
                .ToDictionary(x => x.Key, x => x.Value);

            int i = 1;
            bool famousVlogerInformation = true;
            foreach (var vlogger in vloggers)
            {
                Console.WriteLine($"{i}. {vlogger.Key} : {vlogger.Value[0]} followers, {vlogger.Value[1]} following");

                if (famousVlogerInformation && vlogger.Value[0] > 0)
                {
                    vloggersAndFollowers[vlogger.Key].Sort();

                    foreach (var follower in vloggersAndFollowers[vlogger.Key])
                    {
                        Console.WriteLine($"*  {follower}");
                    }
                    famousVlogerInformation = false;
                }

                i++;
            }
        }
    }
}
