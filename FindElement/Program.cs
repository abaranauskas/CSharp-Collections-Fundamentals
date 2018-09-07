using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindElement
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


            int indexOfTuesday = Array.IndexOf(daysOfWeek, "Tuesday");
            //ras pirma kolekcijoje arba kitaip prades ieskot nuo pradzios
            // LastIndexOf pradetu ieskoti nuo galo
            //Console.WriteLine(indexOfTuesday);


            int indexOfW = Array.FindIndex(daysOfWeek, x => x[0] == 'W');
            int lastIndexOfW = Array.FindLastIndex(daysOfWeek, x => x[0] == 'W');
            //Console.WriteLine(indexOfW);
            //Console.WriteLine(daysOfWeek[indexOfW]);

            string[] lengthOfSix = Array.FindAll(daysOfWeek, x => x.Length == 6);
            foreach (var item in lengthOfSix)
            {
                Console.WriteLine(item);
            }
        }
    }
}
