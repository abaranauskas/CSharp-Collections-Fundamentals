using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetEquals
{
    class Program
    {
        static void Main(string[] args)
        {
            var bigCities = new HashSet<string>()
            {
                "New York", "Manchester", "Sheffield", "Paris"
            };

            var citiesInUK = new HashSet<string>()
            {
                "Sheffield", "Ripon", "Truro", "Manchester"
            };

            var bigCitiesArr = new string[]
            {
                "Paris", "New York", "Manchester", "Sheffield"
            };

            bool areEquals = bigCities.SetEquals(bigCitiesArr);
            Console.WriteLine($"bigCities == bigCitiesArr?: {areEquals}");
            Console.WriteLine();

            bool areEqualsUK = citiesInUK.SetEquals(bigCitiesArr);
            Console.WriteLine($"citisInUK == bigCitiesArr?: {areEqualsUK}");

            //lygina ne refference o value kolekciju viduje
            //metodo kilme is Iset<T> interface
            //eliskumas nesvarbu

        }
    }
}
