using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Roli_The_Coder
{
    public class Event
    {
        public string Name { get; set; }
        public List<string> Participants { get; set; }
    }
   public class Program
    {
       public static void Main()
        {
            var result = new Dictionary<long, Event>();
            var input = Console.ReadLine();
            while (input != "Time for Code")
            {
                var inputParts = input.Split(new[] { ' ' }
            , StringSplitOptions.RemoveEmptyEntries);
                var id = long.Parse(inputParts[0]);
                var eventName = inputParts[1];
                var participants = inputParts.Skip(2).ToList();

                if (!eventName.Contains('#'))
                {
                    input = Console.ReadLine();
                    continue;
                }
                if (result.Keys.Contains(id))
                {
                      if (true)
                      {
                     
                      }
                }



                input = Console.ReadLine();
            }
        }
    }
}