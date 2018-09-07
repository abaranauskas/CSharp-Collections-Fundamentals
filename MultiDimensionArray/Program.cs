using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiDimensionArray
{
    class Program
    {
        static void Main(string[] args)
        {
            float[,] tempGrid = new float[4, 3];
            //new float[x,y]; sukurema gridas is 4 stul ir 3 eil, bet 0 base kai access

            //set reikia for
            for (int x = 0; x < tempGrid.GetLength(0); x++)
            {
                for (int y = 0; y < tempGrid.GetLength(1); y++)
                {
                    tempGrid[x, y] = x + 10 * y;
                }
            }

            Console.WriteLine($"Array ilgis: {tempGrid.Length}");
            Console.WriteLine($"Array dimensiju skaicius: {tempGrid.Rank}");

            //read uztenka foreach
            //behind translatinama i 2 for loop
            foreach (var temp in tempGrid)
            {
                //Console.WriteLine(temp);
            }

            for (int x = tempGrid.GetLowerBound(0); x <= tempGrid.GetUpperBound(0); x++)
            {
                for (int y = tempGrid.GetLowerBound(1); y <= tempGrid.GetUpperBound(1); y++)
                {
                    Console.Write($"{tempGrid[x,y]}, ");
                }
                Console.WriteLine();
            }


            //arrVardas.Length; property gaus visos array ilgi siuo atveju 3x4=12
            //arrVardas.GetLength(0); reikia perduoti rank(kuria dimensija) 
            //gaus pimosios dmensijos ilgi
            //nuli pakeitus 1 antrosios ir t.t.



            //tempGrid.GetLowerBound(0); gaus skliaustuose nurodutos dimensijos(ranko)
            //pradzia. naudojamas pirmam array elementui gauti indeksa kai array ne 0 based
            //praktiskai nenaudojamas tik zinoti

            //tempGrid.GetUpperBound(1); gaus skliaustuose nurodutos dimensijos(ranko)
            //pabaigos indeksa. naudojamas paskutiniam array elementui gauti indeksa
            //praktiskai nenaudojamas tik zinoti
            //geriau naudoti tempGrid.GetLength(0);


        }
    }
}
