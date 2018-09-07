using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Covarience
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Hello, world!";
            object obj = str;

            var strList = new List<string>() { "Monday", "Tuesday" };
            //List<object> objList = (List<object>)strList;
            //negalima ziureti apatini komentara

            IEnumerable<object> objEnum = strList;
            //taim galima nes Ienumerable readonly ir nieko nebus keiciama


            var strList1 = new string[] { "Monday", "Tuesday" };
            object[] objList1 = strList1;
            //ant array galima pakeisti MS leido bet jei pakeitus 
            //bus bandoma pakeisti i ne i stringa o pvz int bus runtime errror
            //todel vieno tipo listu bnegalima keist i object lista
            //vengiant error MS istaise klaida

        }
    }
}
