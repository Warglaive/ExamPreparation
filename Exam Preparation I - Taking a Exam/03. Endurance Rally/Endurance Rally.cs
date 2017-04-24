using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Endurance_Rally
{
   public class Program
    {
       public static void Main()
        {
            var drivers = Console.ReadLine().Split().ToList();
            var zones = Console.ReadLine().Split().Select(double.Parse).ToList();
            var checkPoint = Console.ReadLine().Split().Select(int.Parse).ToList();

            foreach (var driver in drivers)
            {
                double fuel = driver[0];

                for (int i = 0; i < zones.Count; i++)
                {
                    if (checkPoint.Contains(i))
                    {
                        fuel += zones[i];
                    }
                    else
                    {
                        fuel -= zones[i];
                    }
                    if (fuel<=0)
                    {
                        Console.WriteLine($"{driver} - reached {i}");
                        break;
                    }
                }
                if (fuel<=0)
                {
                    continue;
                }
                Console.WriteLine($"{driver} - fuel left {fuel:f2}");
            }
        }
    }
}