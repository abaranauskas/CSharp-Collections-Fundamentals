using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedList
{
    class Program
    {
        static void Main(string[] args)
        {
            var primeMinistes = new SortedList<string, PrimeMinister>
                (new UncasedStringComparer())
            {
                {"JC", new PrimeMinister("James Callaghan", 1976) },
                {"MT", new PrimeMinister("Margaret Thatcher", 1979) },
                {"TB", new PrimeMinister("Tony Blair", 1997) }
            };
            //cia tas pats kad dictionary tik kad yra suruosiuota pagal
            //key alfabeta
            //LinkedList pavadinimas nes visuje key ir value sagoma dviejuose list

            primeMinistes.Add("JM", new PrimeMinister("John Major", 1990));
            Console.WriteLine(primeMinistes["tb"]);

            foreach (var item in primeMinistes)
            {
                Console.WriteLine(item);
            }
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
