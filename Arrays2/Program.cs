using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1;  //reiksme tarsi 0
            int[] x2; //reiksme tarsi null

            int x3 = 5;

            int[] x4 = new int[5];  //viso reiksmes bus 0
            Console.WriteLine(x4[1]); //0

            int[] x5 = new int[5] {1,4,9,16,25};
            int[] x6 = new int[] { 1, 4, 9, 16, 25 };
            int[] x7 = { 1, 4, 9, 16, 25 };
            var x8 = new int[5] { 1, 4, 9, 16, 25 };
            //visi 4 tinkami budai deklaruoti array, bet vienokiu ar 
            //kitokiu budu reikia nurodyti array ilgi ir tipa
        }
    }
}
