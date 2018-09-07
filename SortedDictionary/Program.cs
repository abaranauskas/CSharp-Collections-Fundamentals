using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            var primeMinistes = new SortedDictionary<string, PrimeMinister>
                (new UncasedStringComparer())
            {
                {"JC", new PrimeMinister("James Callaghan", 1976) },
                {"MT", new PrimeMinister("Margaret Thatcher", 1979) },
                {"TB", new PrimeMinister("Tony Blair", 1997) }
            };
            //praktiskai tas pats kas SortedList, tik internal skirtumas
            //geriau naudoti SortedDictionary nes greitesnis nei sorted list

            primeMinistes.Add("JM", new PrimeMinister("John Major", 1990));

            Console.WriteLine(primeMinistes["tb"]);


        }
    }

    class UncasedStringComparer : IComparer<string>
    {
        public int Compare(string x, string y)
        {
            return string.Compare(x, y, StringComparison.InvariantCultureIgnoreCase);
        }
    }
}

