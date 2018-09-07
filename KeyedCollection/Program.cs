using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyedCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            var primeMinistes = new PrimeMinisterByYearDictionary()               
            {
                new PrimeMinister("James Callaghan", 1974) ,
                new PrimeMinister("Margaret Thatcher", 1979) ,
                new PrimeMinister("Tony Blair", 1997) 
            };            

            primeMinistes.Add(new PrimeMinister("John Major", 1990));

            Console.WriteLine("tony is "+primeMinistes[1997]);

            foreach (var item in primeMinistes)
            {
                Console.WriteLine(item);
            }

        }
    }

    class PrimeMinisterByYearDictionary : KeyedCollection<int, PrimeMinister>
    {
        protected override int GetKeyForItem(PrimeMinister item)
        {
            return item.YearElected;
        }
    }
}
