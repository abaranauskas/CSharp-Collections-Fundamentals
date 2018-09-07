using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayRevere
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] daysOfWeek = {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };

            //Array.Reverse(daysOfWeek); //static method
            daysOfWeek = daysOfWeek.Reverse().ToArray(); //Linq
            var reversed = daysOfWeek.Reverse(); //IEnumerable returnina

            foreach (var item in reversed)
            {
                Console.WriteLine(item);
            }
        }
    }
}
