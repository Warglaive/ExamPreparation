﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
namespace _03.Nether_Realms
{
    public class Demon
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public double Damage { get; set; }
    }
   public class Program
    {
       public static void Main()
        {
            var demons = Console.ReadLine()
                .Split(new[] { ' ', ',' }
            ,StringSplitOptions.RemoveEmptyEntries);
            var result = new SortedDictionary<string, Demon>();
            foreach (var demon in demons)
            {
                var healthSymbols = demon
                    .Where(
                    s => !char.IsDigit(s) && 
                    s != '+' && 
                    s != '-' && 
                    s != '*' && 
                    s != '/' &&
                    s != '.');
                var health = 0;
                foreach (var healthSymbol in healthSymbols)
                {
                    health += healthSymbol;
                }
                var regex = new Regex(@"-?\d+\.?\d*");
                var matches = regex.Matches(demon);
                var damage = 0.0;
                foreach (Match match in matches)
                {
                    var currentNumber = double.Parse(match.Value);
                    damage += currentNumber;
                }
                var modifiers = demon.Where(s => s == '*' 
                || s == '/');
                foreach (var modifier in modifiers)
                {
                    if (modifier =='*')
                    {
                        damage *=2;
                    }
                    else
                    {
                        damage /= 2;
                    }
                }
                result.Add(demon, new Demon
                {
                    Health = health,
                    Damage = damage
                });                
            }
            foreach (var demonEntry in result)
            {
                var demon = demonEntry.Value;
                Console.WriteLine($"{demonEntry.Key} - {demon.Health} health, {demon.Damage:f2} damage ");
            }
        }
    }
}