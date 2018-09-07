using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumerateItems
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string[] daysOfWeek =
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };
            //jei perduodam Array tiesiogiai i foreach loop tada jis viduje
            //pasivercia i for loop nes taip efektyviau
            //bet jei mes perduodam i kokia funcija kur labiau generic
            //ir priima IEnumerable<T> tada eina ipratu budu per 
            //GetEunmerator() metoda. kaip DisplayItems() metode


            //DisplayItems(daysOfWeek);
            DisplayItems2(daysOfWeek); 
            //veiks taip pat
                      
           // DisplayItems("Hello, World"); // stringas yra Ienumerable
           
            
        }


        //po kompileciajos jie veiks identiskai
        public static void DisplayItems<T>(IEnumerable<T> colection)
        {
            using (IEnumerator<T> enumerator = colection.GetEnumerator())
            {
                bool moreItems = enumerator.MoveNext();
                while (moreItems)
                {
                    T item = enumerator.Current;
                    Console.WriteLine(item);
                    moreItems = enumerator.MoveNext();
                }
            }
        }


        public static void DisplayItems2<T>(IEnumerable<T> colection)
        {
            foreach (T item in colection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
