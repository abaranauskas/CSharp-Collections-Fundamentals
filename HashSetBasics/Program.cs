using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashSetBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            var bigCities = new HashSet<string>()
            {
                "New York", "Manchester", "Sheffield", "Paros"
            };

            bool addShef = bigCities.Add("Sheffield");
            //kadangi sutampa HashSet neleidzia kad pasikartotu
            //garantuotas unikalumas
            bool addBeij = bigCities.Add("Beijing");
            //returnina bool kai list returnina void, aisku auto itraukia arba ne

            Console.WriteLine($"ar itrauktas sefildas: {addShef}");
            Console.WriteLine($"ar itrauktas pekinas: {addBeij}");
            Console.WriteLine();

            foreach (var city in bigCities)
            {
                Console.WriteLine(city);
            }


        }
    }
}
