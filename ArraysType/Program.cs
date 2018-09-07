using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysType
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] x1 = {1,4,9,16,25 };
            var x2 = x1;
            x2[0] = 123;

            //Console.WriteLine($"x1 == x2? {ReferenceEquals(x1,x2)}");

            object[] objArray = new object[]{
                "Hello world",
                4,
                new DateTime(2015,01,01)
            };
            //tam tikro objeto array galima 
            //laikyti netik to tipo abjectus bet 
            //ir kas tai kieno tas objectas base
            string[] asas = { "Saaa", "asas" };
            Type type = asas.GetType();

            foreach (var item in objArray)
            {
                Console.WriteLine(item);
            }
        }
    }
}
