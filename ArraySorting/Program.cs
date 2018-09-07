using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySorting
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

            Array.Sort(daysOfWeek); //pagal alfabeta

            var comparer = new StringLengthComparer();
            Array.Sort(daysOfWeek, comparer);

            foreach (var item in daysOfWeek)
            {
                Console.WriteLine(item);
            }
        }
    }

    public class StringLengthComparer: IComparer<string> 
    {
        public int Compare(string x, string y)
        {
            return x.Length.CompareTo(y.Length);
        }
    }
}
