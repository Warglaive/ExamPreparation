using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
   public class Program
    {
       public static void Main()
        {
            var wormLenght = long.Parse(Console.ReadLine());
            var wormWidth = decimal.Parse(Console.ReadLine());
            var mmToCm = wormLenght * 100;
            var remainder = mmToCm % wormWidth;
            var product = mmToCm * wormWidth;
            var percent = (wormLenght * 10000) / wormWidth;
            if (remainder == 0m)
            {
                Console.WriteLine($"{product:f2}");
            }
            else
            {
                Console.WriteLine($"{percent:f2}%");
            }
        }
    }
}