using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Ladybugs
{
   public class Program
    {
       public static void Main()
        {
            var fieldZise = long.Parse(Console.ReadLine());

            var cellsInTheField = new List<int>();
            var ladyBugsIndexes = Console.ReadLine().Split().Select(long.Parse).ToList();

            for (int i = 0; i < fieldZise; i++)
            {
                cellsInTheField.Add(0);
            }
            var commands = Console.ReadLine();

            while (commands != "end") 
            {
                var inputParts = commands.Split().ToList();
                var ladyBugIndex = int.Parse(inputParts[0]);
                var direction = inputParts[1];
                var flyLenght = int.Parse(inputParts[2]);
                if (direction == "right") 
                {
                    ladyBugIndex += flyLenght;
                    if (ladyBugIndex < fieldZise)
                    {

                        while (ladyBugsIndexes.Contains(ladyBugIndex))
                        {
                            ladyBugIndex += flyLenght;
                        }
                    }
                }
                commands = Console.ReadLine();
            }
            Console.Write(string.Join(" ", cellsInTheField));
            
           Console.WriteLine();
        }
    }
}