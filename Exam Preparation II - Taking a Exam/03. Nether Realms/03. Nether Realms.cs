using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace _03.Nether_Realms
{
   public class Program
    {
       public static void Main()
        {
            var demons = Console.ReadLine().Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            var result = new SortedDictionary<string, Demon>();
            foreach (var demon in demons)
            {
                var healthSymbols = demon.Where(s =>
                !char.IsDigit(s) &&
                s != '+' &&
                s != '-' &&
                s != '*' &&
                s != '/' &&
                s != '.');
                var health = 0;
                foreach (var healtSymbol in healthSymbols)
                {
                    health += healtSymbol;
                }

                var regex = new Regex(@"-?\d+\.?\d*");
                var matches = regex.Matches(demon);
                var damage = 0.0;
                foreach (Match match in matches)
                {
                    var currentNumber = double.Parse(match.Value);
                    damage += currentNumber;
                }
                var modifiers = demon.Where(s => s == '*' || s == );
                foreach (var modifier in modifiers)
                {
                    damage;
                }
                
                
            }
        }
    }
}
