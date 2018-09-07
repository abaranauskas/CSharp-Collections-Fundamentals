using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string monday = "Monaday";

            string[] daysOfWeek = {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };

            //string tuesday = daysOfWeek[1];
            //Console.WriteLine(tuesday);

            //Console.WriteLine("Parasykite savaites dieno indeksa kuri norite matyti nuo 0 iki 6.");
            //int dayIndex = int.Parse(Console.ReadLine());
            //Console.WriteLine(daysOfWeek[dayIndex]);


            //daysOfWeek[5] = "PartyDay";

            MakePlular(daysOfWeek);
            foreach (var day in daysOfWeek)  //day kintamasis yra read only per ji negalim pakeisti array
            {
                Console.WriteLine(day);
            }


            //for (int i = 0; i < daysOfWeek.Length; i++)
            //{
            //    Console.WriteLine(daysOfWeek[i]);
            //}
        }

        static void MakePlular(string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = array[i] + "s";
            }
        }
    }
}
