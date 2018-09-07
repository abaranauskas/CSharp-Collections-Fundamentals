using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayCopyTo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] square = { 1, 4, 9, 16 };

            int[] copy = new int[4];
            square.CopyTo(copy, 0); //skaicius nurodo kokiu indeksu pradet kopijuoti
            //is square[] kopijuoja i copy []

            copy = square.ToArray(); //Linq metodas

            //Array.Copy(square, copy, 2); //statinis metodas is square i copy 2 ilgis

            foreach (var item in copy)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(square==copy);
        }
    }
}
