using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Worms_World_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = new SortedDictionary<List<string>, Dictionary<string, long>>();
            var input = Console.ReadLine();
            while (input != "quit")
            {
                var inputParts = input.Split(new[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                var wormName = inputParts[0];
                var wormTeam = inputParts[1];
                var wormScore = long.Parse(inputParts[2]);
                
                input = Console.ReadLine();
            }
            var counter = 0;
        }
    }
}