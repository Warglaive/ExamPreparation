using System;
using System.Globalization;
namespace _01.Softuni_Coffee_Orders
{
    public class Program
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var totalPrice = 0.0m;
            for (int i = 0; i < n; i++)
            {
                var pricePerCapsule = decimal.Parse(Console.ReadLine());
                var orderDate = DateTime.ParseExact(Console.ReadLine()
                    , "d/M/yyyy", CultureInfo.InvariantCulture);
                var capsuleCount = int.Parse(Console.ReadLine());
                var year = orderDate.Year;
                var month = orderDate.Month;
                decimal daysInMonth = DateTime.DaysInMonth(year, month);
                var price = (daysInMonth * capsuleCount) * pricePerCapsule;
                Console.WriteLine($"The price for the coffee is: ${price:f2}");
                totalPrice += price;
            }
            Console.WriteLine($"Total: ${totalPrice:f2}");
         }
    }
}