using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayType2
{
    class Program
    {
        static void Main(string[] args)
        {
            object[] objArr = new object[3];

            string[] daysOfWeek = {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };

            objArr[0] = 3;
            Console.WriteLine(objArr[0]);

            object[] objArr2 = daysOfWeek;
            //objArr2[1] = 2; negalima nes ojecto arrauy referina string array

            foreach (var item in objArr2)
            {
                Console.WriteLine(item);
            }
        }
    }
}
