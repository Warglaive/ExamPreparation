using System;
namespace _01.Sino_The_Walker
{
    public class Program
    {
        public static void Main()
        {
            var inputTime = Console.ReadLine();
            var stepsTaken = int.Parse(Console.ReadLine()) % 86400; // deleno na 24 chasa
            var secondsForStep = int.Parse(Console.ReadLine()) % 86400; //// deleno na 24 chasa
            var time = DateTime.Parse(inputTime);

            var totalTime = stepsTaken * secondsForStep;

            var spanTime = TimeSpan.FromSeconds(totalTime);
            var total = time + spanTime;
            Console.WriteLine("Time Arrival: {0:HH:mm:ss}",total);
        }
    }
}