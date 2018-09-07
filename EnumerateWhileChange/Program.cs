using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumerateWhileChange
{
    class Program
    {
        static void Main(string[] args)
        {
            var days = new List<string>()
            {
                "Monday",
                "Tuesday",
                "Wednesday",
            };

            foreach (string day in days)
            {
                days[1] = "2nd day"; 
                //negalima modifikuoti kolekcijos kol Enumeruojama per ja
                //runtime error bus. jei butu Array ne List. tada viskas butu gerai
                //nes foreach pasikeicia i for loop.

                Console.WriteLine(day);
            }
        }
    }
}
