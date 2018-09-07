using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intersect
{
    class Program
    {
        static void Main(string[] args)
        {
            var bigCities = new HashSet<string>()
            {
                "New York", "Manchester", "Sheffield", "Paris"
            };

            string[] citiesInUK = {"Sheffield", "Ripon", "Truro", "Manchester" };

            bigCities.IntersectWith(citiesInUK);
            //modifikuoja bigCities palieka tiek tuos kurie sutampa
            //["Sheffield", "Manchester"]

            var newCities = bigCities.Intersect(citiesInUK);
            //linq metodas vietoj to kad modifikuotu originala
            //returnina nauja IEnumerable
            //["Sheffield", "Manchester"]

            //bigCities.UnionWith(citiesInUK);
            //originala pakeis i toki Ienum kad butu visi elementa kurie yra per abi 
            //kolekciajas bet nesikartodamos
            //["New York", "Manchester", "Sheffield", "Paris", , "Ripon", "Truro"]

            //bigCities.SymmetricExceptWith(citiesInUK);
            //originala pakeis i toki Ienum kad butu visi elementa kurie
            //nera abiejose kolekcijose
            //["New York", "Paris", , "Ripon", "Truro"]

            bigCities.ExceptWith(citiesInUK);
            //originala pakeis i toki Ienum kad butu visi elementa kurie
            //yra pirmose kolekcijoje bet ner antroje. is pirmos atimama antra
            //["New York", "Paris"]


            //Linq turi visus metodus kaip intersect isskyrus SymmetricExcept()
            //skiresia tuo kad neturi With gale metodo vardo ir 
            //Linq metodas returnina 
            //ISet<T> metodas mofifikuoja




            foreach (var city in bigCities)
            {
                Console.WriteLine(city);
            }
        }
    }
}
