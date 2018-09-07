using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
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

            Array.Sort(daysOfWeek);

            var indexOfSun = Array.BinarySearch(daysOfWeek, "Sunday");
            //naudoti tik tada kai labai daug elementu
            //veikia taip  kad ima viduriny nari ir ziuri kurioj pusej jis yra
            //turi but gerai surusiuota, gali prireikt Icomparer pasirasyt

            Console.WriteLine($"Index of Sunday: {indexOfSun}");

            foreach (var item in daysOfWeek)
            {
                Console.WriteLine(item);
            }
        }
    }
}
