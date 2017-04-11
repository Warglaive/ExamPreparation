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
            var size = int.Parse(Console.ReadLine());
            var ladyBugIndexes = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            var field = new int[size];
            foreach (var ladyBugIndex  in ladyBugIndexes)
            {
                if (ladyBugIndex<0 || ladyBugIndex>=size)
                {
                    continue;
                }
                
            }
        }
    }
}
