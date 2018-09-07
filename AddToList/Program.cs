using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddToList
{
    class Program
    {
        static void Main(string[] args)
        {
            var presidents = new List<string>() {
                "Jimmy Carter",
                "Ronald Reagan",
                "George HW Bush",
                "Bill Clinton",
                "George W Bush"
            };


            Console.WriteLine("Before");
            Console.WriteLine($"Count: {presidents.Count}");
            Console.WriteLine($"Capacity: {presidents.Capacity} \r\n");
            presidents.Add("Barac Obama");
            presidents.Add("Barac Obama");
            presidents.Add("Barac Obama");
            presidents.Add("Barac Obama");
            presidents.Add("Barac Obama");
            presidents.Add("Barac Obama");
            presidents.Add("Barac Obama");
            presidents.Add("Barac Obama");
            //kai pasikiama capasity riba ir pridedamas sekantis list
            //capacity padvigubeja

            presidents.RemoveAt(2); //istrins pagal indeksa
            presidents.Remove("Bill Clinton"); //istrins pagal value
            presidents.RemoveAll(p=>p=="Barac Obama"); //lamda istrinti isus kurie atitinka kriteriju


            Console.WriteLine("After");
            Console.WriteLine($"Count: {presidents.Count}");
            Console.WriteLine($"Capacity: {presidents.Capacity} \r\n");

            Console.WriteLine("-----------------------------------------");

            var copy2 = new ReadOnlyCollection<string>(presidents);
            //name space objectModels.
            //veiks analogiskai kaip ir sekanti eilute

            var copy = presidents.AsReadOnly();
            ExternalUserMethod(copy);
            //AsReadOnly() metodas supakuos List ir returnins IList<T>
            //ir leis tik nuskaityt jei bandysi pakeisr exeption

            foreach (var item in presidents)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-----------------------------------------");


        }

        static void ExternalUserMethod(IList<string> presidents)
        {
            presidents.RemoveAt(1);
            //Console.WriteLine(presidents.Count);
        }
    }
}
