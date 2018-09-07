using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementEnumerator
{
    class Program
    {
        static void Main(string[] args)
        {
            var allDays = new AllDaysOfWeek();

            allDays.add("monday");
            allDays.add("2nd day");


            foreach (var day in allDays)
            {
                Console.WriteLine(day);
            }

        }
    }

    class AllDaysOfWeek : IEnumerable<string>
    {
        List<string> days = new List<string>();

        public void add(string x)
        {
            days.Add(x);
        }
        

        public IEnumerator<string> GetEnumerator()
        {
            Console.WriteLine("Saukiamas generinis GetEnumerator");
            foreach (var day in days)
            {

                yield return day;
            }

            
            yield return "Wednesday";
            yield return "Thursday";
            //viska daro yield return
        }



        //cia yra senas negenerinis interface kuris apienamas saukiant nauja
        IEnumerator IEnumerable.GetEnumerator()
        {
           return GetEnumerator();
        }
        //generinis paverdi is negenerinio
    }
}
