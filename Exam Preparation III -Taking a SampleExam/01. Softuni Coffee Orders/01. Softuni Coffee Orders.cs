using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
namespace _01.Softuni_Coffee_Orders
{
   public class Program
    {
       public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {

                string[] inputParams = Console.ReadLine().Split('/');
                string root = inputParams[0];
                string[] fileParams = inputParams[inputParams.Length - 1].Split(new[] { '.', ';' },StringSplitOptions.RemoveEmptyEntries);
                string FileName = fileParams[1];

            }
            //query
        }
    }
}
