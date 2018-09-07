using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedSet
{
    class Program
    {
        static void Main(string[] args)
        {

            var bigCities = new SortedSet<string>
                            //(StringComparer.InvariantCultureIgnoreCase)
                            (new uncasedComparer())
            {
                "New York", "Manchester", "Sheffield", "Paris"
            };

            bigCities.Add("Sheffield".ToUpper());
            bigCities.Add("Bejing".ToUpper());

            foreach (var city in bigCities)
            {
                Console.WriteLine(city);
            }

            //nuo HashSet<T> skirtumas tik tas kad cia bus surusiuota. jei yra zinoma kaip rusiuoti
            //kaip pvz siuo arveju nes stringu kolekcija. bet jei butu own type
            //reiktu i konstruktoriu perduoti IComparer<T>
        }
    }

    class uncasedComparer : IComparer<string>
    {
        public int Compare(string x, string y)
        {
            //return x.ToUpper().CompareTo(y.ToUpper());
            return string.Compare(x, y, StringComparison.InvariantCultureIgnoreCase);
        }
    }
}
