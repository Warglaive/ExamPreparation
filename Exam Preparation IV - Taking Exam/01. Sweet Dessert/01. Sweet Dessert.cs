using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Sweet_Dessert
{
   public class Program
    {
       public static void Main()
        {
            var ivanchoCash = double.Parse(Console.ReadLine());
            var guests = double.Parse(Console.ReadLine());
            var bananaPrice = double.Parse(Console.ReadLine());
            var eggsPrice = double.Parse(Console.ReadLine());
            var berriesPrice = double.Parse(Console.ReadLine());

            var setsAndPortions = Math.Ceiling(guests / 6);
            var neededProducts = setsAndPortions * (2 * bananaPrice) + setsAndPortions * (4 * eggsPrice) + setsAndPortions * (0.2 * berriesPrice);
            var neededMoney = neededProducts - ivanchoCash;
            if (neededProducts<= ivanchoCash)
            {
                Console.WriteLine($"Ivancho has enough money - it would cost {neededProducts:f2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivancho will have to withdraw money - he will need {neededMoney:f2}lv more.");
            }
        }
    }
}