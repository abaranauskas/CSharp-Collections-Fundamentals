using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumerateArray
{
    class Program
    {
        static void Main(string[] args)
        {
           var daysOfWeek = new List<string>(){
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };

            foreach (var item in daysOfWeek)
            {
                //Console.WriteLine(item);
            }

            string[] daysOfWeek2= {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };
            

            ICollection<string> colection = (ICollection<string>)daysOfWeek2;
            Console.WriteLine("count: " + colection.Count);
            Console.WriteLine("count: " + colection.Count()); //Linq
            //jei tik imanoma geriau naudoti Count property ne Linq methoda
            Console.WriteLine("Length: " + daysOfWeek2.Length); //Length tik Array turi

            Console.WriteLine("----------------------------------");

            //colection.Add("Slaveday");
            //turi Add() nes castinta i ICollection<T> bet galiau tai array 
            //ir add metodo neturi, todel runtime error. Readonly
            
            if (!colection.IsReadOnly)
                colection.Add("Slaveday");
            else
                Console.WriteLine("Array fixed size");
                //negalima praplesiti array

            (colection as string[])[5] = "Slaveday";
            //bet galima pakeisti elementa jei castinam atgal i arrra
            //todel readOnly property salygine
            //Readony property sako kad negalima modifikuoti su IColection<t> metodais
            //bet nesako kad negalima modifikuoti su array metodais

            foreach (var item in colection)
            {
                Console.WriteLine(item);
            }



        }
    }
}
