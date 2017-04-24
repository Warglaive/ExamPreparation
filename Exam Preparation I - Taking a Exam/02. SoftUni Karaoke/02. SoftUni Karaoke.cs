using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.SoftUni_Karaoke
{
    public class Program
    {
        public static void Main()
        {

            var participants = Console.ReadLine().Split(new[] { ',', ' ' }
            , StringSplitOptions.RemoveEmptyEntries)
                .ToList();

                var songs = Console.ReadLine().Split(new[] { ',' }
                , StringSplitOptions.RemoveEmptyEntries).Select(y => y.Trim())
                .ToList();
            var result = new Dictionary<string, List<string>>();

            if (participants.Count >= 1 && participants.Count <= 100 && songs.Count >= 1 && songs.Count <= 100) 
            {

                var stagePerformance = Console.ReadLine();
                if (stagePerformance == "dawn")
                {
                    Console.WriteLine("No awards");
                    return;
                }
                while (stagePerformance != "dawn")
                {

                    var token = stagePerformance.Split(new[] { ',' }
                , StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
                    var participant = token[0].Trim();
                    var songForParticipant = token[1].Trim();
                    var award = token[2].Trim();
                    if (participants.Contains(participant) && songs.Contains(songForParticipant)) //possible bug
                    {
                        if (!result.ContainsKey(participant))
                        {
                            result.Add(participant, new List<string>());
                        }
                        if (!result[participant].Contains(award))
                        {
                            result[participant].Add(award);
                        }
                    }

                    stagePerformance = Console.ReadLine();
                }
            }
            else
            {
                Console.WriteLine("No awards");
                return;
            }
            foreach (var KvP in result
                .OrderByDescending(x => x.Value.Count).ThenBy(y => y.Key)) 
            {
                if (KvP.Value.Contains(string.Empty))
                {
                    Console.WriteLine("No awards");
                    break;
                }
                Console.WriteLine($"{KvP.Key}: {result[KvP.Key].Count} awards");
                foreach (var award in KvP.Value.OrderBy(x => x)) 
                {
                    Console.WriteLine($"--{award}");
                }
            }
        }
    }
}