using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            var citiesInUK = new HashSet<string>()
            {
                "Sheffield", "Ripon", "Truro", "Manchester"
            };

            var bigUkCities = new HashSet<string>()
            {
                "Manchester", "Sheffield"
            };

            var bigCitiesset= new HashSet<string>()
            {
                "New York", "Manchester", "Sheffield", "Paris"
            };

            var ukIsSubset = citiesInUK.IsSubsetOf(bigCitiesset);
            Console.WriteLine($"Uk cities subset of big cities list?: {ukIsSubset}");

            var bigUkIsSubset = bigUkCities.IsSubsetOf(bigCitiesset);
            Console.WriteLine($"big Uk cities subset of big cities list?: {bigUkIsSubset}");
            Console.WriteLine();

            var superSetOfUkCities = bigCitiesset.IsSupersetOf(citiesInUK);
            Console.WriteLine($"big cities list is superset of UK cities?: {superSetOfUkCities}");

            var superSetOfBigUkCities = bigCitiesset.IsSupersetOf(bigUkCities);
            Console.WriteLine($"big cities list is superset of big UK cities?: {superSetOfBigUkCities}");

            //yra dar IsProperSupersetOf() ir IsProperSubsetOf()
            //neskaito jei tur vienodus elementus????
            //netru linq ekvivalentu visi metodai menti anksciau
        }
    }
}
