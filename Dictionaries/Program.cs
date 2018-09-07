using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            var primeMinistes = new Dictionary<string, PrimeMinister>
                (new UncaseStringEqualityComparer())
            {
                {"JC", new PrimeMinister("James Callaghan", 1976) },
                {"MT", new PrimeMinister("Margaret Thatcher", 1979) },
                {"TB", new PrimeMinister("Tony Blair", 1997) }
            };

            Console.WriteLine(primeMinistes["Mt"]); //case sensitive







            //---------------------------------------------------------
            PrimeMinister p = primeMinistes["TB"];
            //Console.WriteLine(p);

            primeMinistes["JC"] = new PrimeMinister("Jim Callaghan", 1976);
            //per key galima priskirti nauja objecta

            primeMinistes["JM"] = new PrimeMinister("John Major", 1990);
            primeMinistes.Add("GB", new PrimeMinister("Gordon brown", 2007));
            //priedeti galima i dictionary dviem budais Auksciau dvi eilutes.
            //taciau jei naudotume Add metoda. o inicialai jau ekzisyuotu
            // tada nepakeistu kaip naudojant []. o mestu erora kad toks key jau yra
            //pridedama visada i dictionary gala

            primeMinistes.Remove("JC");
            //pasalinimui uztenka tik key

            foreach (var pm in primeMinistes)
            {
                //Console.WriteLine(pm.Key+", " + pm.Value);
                
            }

            PrimeMinister pm2;
            bool found = primeMinistes.TryGetValue("DC", out pm2);
            //z.TryGetValue(x, out y); bando surast x key in z dictionary
            //jei randa garazina ta value i psirasyta kint

            if (found)
            {
                Console.WriteLine(pm2+ "found");
            }
            else
            {
                //Console.WriteLine("Value doesnt exist in dictionary");
            }
        }
    }
}
