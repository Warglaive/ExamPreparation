using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Charity_Marathon
{
   public class Program
    {
       public static void Main()
        {
            var days = long.Parse(Console.ReadLine());
            var runners = long.Parse(Console.ReadLine());
            var lapsPerRunner = long.Parse(Console.ReadLine());
            var lapLenght = long.Parse(Console.ReadLine());
            var trackCapacity = long.Parse(Console.ReadLine());

            var moneyPerKm = decimal.Parse(Console.ReadLine());


            var totalCapacity = trackCapacity * days;
            if (totalCapacity > runners)
            {
                totalCapacity = runners;
            }
            var totalMeters = totalCapacity * lapsPerRunner * lapLenght;
            var totalKilometers = totalMeters / 1000;
            var raisedMoney = totalKilometers * moneyPerKm;
            Console.WriteLine($"Money raised: {raisedMoney:f2}");
        }
    }
}
