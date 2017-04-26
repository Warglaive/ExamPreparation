using System;

namespace _01.Charity_Marathon
{
    public class Program
    {
       public static void Main()
        {
            var marathonLengthDays = long.Parse(Console.ReadLine());
            var listedRunners = long.Parse(Console.ReadLine());
            var lapsCount = long.Parse(Console.ReadLine());
            var lapLenght = long.Parse(Console.ReadLine());
            var trackCapacity = long.Parse(Console.ReadLine());
            var moneyPerKilometer = decimal.Parse(Console.ReadLine());

            var maxRunnesPerDay = trackCapacity * marathonLengthDays;
            if (listedRunners < maxRunnesPerDay)
            {
                maxRunnesPerDay = listedRunners;
            }
            var totalMeters = maxRunnesPerDay * lapsCount * lapLenght;
            var TotalKm = totalMeters / 1000;
            var moneyRaised = TotalKm * moneyPerKilometer;
            Console.WriteLine("Money raised: {0:f2}", moneyRaised);
        }
    }
}