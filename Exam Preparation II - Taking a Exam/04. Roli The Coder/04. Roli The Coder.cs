using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Roli_The_Coder
{
   public class Program
    {
       public static void Main()
        {
            while (true)
            {
                var currentLines = Console.ReadLine();
                if (currentLines == "Time for Code")
                {
                    break;
                }
                var lineParts = currentLines.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var eventId = 0;
                if (int.TryParse(lineParts[0], out eventId))
                {
                    continue;
                }
                string eventName = string.Empty;
                if (lineParts.Length > 1 && lineParts[1].StartsWith("#")) 
                {
                    eventName = lineParts[1].Trim('#');
                }
                else
                {
                    continue;
                }
                if (lineParts.Length > 2)
                    lineParts
                    .Skip(2);

                  
                {
                    lineParts = lineParts.Skip(2).ToArray();
                }
            }
        }
    }
}
