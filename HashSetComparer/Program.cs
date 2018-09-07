using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashSetComparer
{
    class Program
    {
        static void Main(string[] args)
        {
            var bigCities = new HashSet<string>
                (StringComparer.InvariantCultureIgnoreCase)
                //(new UncasesStringEqualityComparer())
            {
                "New York", "Manchester", "Sheffield", "Paros"
            };

            bigCities.Add("SHEFFIELD");           
            bigCities.Add("BEIJING");
            //jei nepateiktas stringcomparison bus abu itraukti
                     

            foreach (var city in bigCities)
            {
                Console.WriteLine(city);
            }
        }
    }

    class UncasesStringEqualityComparer : IEqualityComparer<string>
    {
        public bool Equals(string x, string y)
        {
            return x.ToUpper() == y.ToUpper();
        }

        public int GetHashCode(string obj)
        {
            return obj.ToUpper().GetHashCode();
        }
    }
}
