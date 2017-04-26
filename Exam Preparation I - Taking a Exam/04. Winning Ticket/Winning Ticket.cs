using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.Winning_Ticket
{
   public class Program
    {
       public static void Main()
        {
            var tickets = Console.ReadLine()
                .Split(new[] { ',', ' ' }
                ,StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            foreach (var ticket in tickets)
            {

                var pattern = @"([@#$^])\1{5,}"; 
                var regex = new Regex(pattern);
                var isWinning = regex.IsMatch(ticket);
                var symbol = ' ';
                long symbolCount = 0;
                if (isWinning)
                {
                    symbol = ticket[4];
                }
                foreach (var ticketSymbol in ticket)
                {
                    if (ticketSymbol == symbol)
                    {
                        symbolCount++;
                    }
                }
                if (ticket.Length != 20) 
                {
                    Console.WriteLine("invalid ticket");
                    continue;
                }
                symbolCount = symbolCount / 2;
                if (isWinning == false)
                {
                    Console.WriteLine($"ticket \"{ticket}\" - no match");
                    continue;
                }
                if (symbolCount >= 6 && symbolCount <= 9) 
                {
                    Console.WriteLine($"ticket \"{ticket}\" - {symbolCount}{symbol}");
                }
                else
                {
                    Console.WriteLine($"ticket \"{ticket}\" - {symbolCount}{symbol} Jackpot!");
                }
            }
        }
    }
}