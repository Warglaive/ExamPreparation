using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Wormhole
{
    class Program
    {
        static void Main(string[] args)
        {
            var wormHoles = Console.ReadLine()
                .Split(new[] { ' ' }
            , StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            var count = 0;
            for (int i = 0; i < wormHoles.Count; i++)
            {

                var currentNumber = wormHoles[i];
                if (currentNumber == 0)
                {
                    count++;
                    continue;
                }
                else
                {
                    count++;
                    
                    var wormHole = wormHoles.IndexOf(currentNumber); 

                    wormHoles[wormHole] = 0;
                    //teleport to currentNumber's index
                    i = currentNumber;
                }
            }
            Console.WriteLine(count);
        }
    }
}