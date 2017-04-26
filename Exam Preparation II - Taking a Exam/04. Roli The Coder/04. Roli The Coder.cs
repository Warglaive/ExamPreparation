using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Roli_The_Coder
{
   public class Program
    {
       public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            Console.WriteLine(new string('*', n));
            for (int i = 0; i < n-2; i++)
            {
                Console.Write("*");
                Console.WriteLine(new string(' ', n-2));
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}
