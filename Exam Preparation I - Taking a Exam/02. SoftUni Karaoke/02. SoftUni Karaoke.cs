using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.SoftUni_Karaoke
{
  public  class Program
    {
       public static void Main()
        {

            var participants = Console.ReadLine().Split(new[] { ',', ' ' }
            , StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            var songs = Console.ReadLine().Split(new[] { ','}
            , StringSplitOptions.RemoveEmptyEntries).Select(y => y.Trim())
            .ToList();

            var result = new Dictionary<string, List<string>>();

            var stagePerformance = Console.ReadLine();
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
                        result[participant].Add(award);
                    }
                }

                stagePerformance = Console.ReadLine();
            }
        }
    }
}