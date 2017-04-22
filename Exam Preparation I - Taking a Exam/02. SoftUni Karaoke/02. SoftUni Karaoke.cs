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

            var song = Console.ReadLine().Split(new[] { ',',  }
            , StringSplitOptions.RemoveEmptyEntries)
            .ToList();
            var stagePerformance = Console.ReadLine();
            while (stagePerformance != "dawn") 
            {
                var token = stagePerformance.Split(new[] { ',', ' ' }
            , StringSplitOptions.RemoveEmptyEntries)
                .ToList();


                var participant = token[0];
                var songForParticipant = token[1];
                var award = token[3];


                stagePerformance = Console.ReadLine();
            }
        }
    }
}