using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            float[][] tempGrid = new float[4][];
            Console.WriteLine($"Array ilgis: {tempGrid.Length}");
            Console.WriteLine($"Array (Rank)dimensiju skaicius: {tempGrid.Rank}");

            for (int x = 0; x < tempGrid.Length; x++)
            {
                tempGrid[x] = new float[3];
                for (int y = 0; y < tempGrid[x].Length; y++)
                {
                    tempGrid[x][y] = x + 10 * y;
                }
            }
                      

            for (int x = 0; x < tempGrid.Length; x++)
            {
                for (int y = 0; y < tempGrid[x].Length; y++)
                {
                    Console.Write($"{tempGrid[x][y]}, ");
                }
                Console.WriteLine();
            }

        }
    }
}
