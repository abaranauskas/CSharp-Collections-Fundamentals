using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists
{
    class Program
    {
        static void Main(string[] args)
        {

            var presidens = new LinkedList<string>(); //negalima suvesti per {} iskart

            presidens.AddLast("JFK");
            presidens.AddLast("Lyndon B Johnson");
            presidens.AddLast("Richard Nixon");
            presidens.AddLast("Jimmy Carter");
            
            

            //LinkedListNode<string> node2 = presidens.Find("JFK");
            //presidens.Remove(node2);
            //galima istrinti ir per LinkListNode ir per string tiesiogiai
            //bet kadangi zinoma kad JFK pirmas optimaliausia removeFirst

            presidens.RemoveFirst();
            LinkedListNode<string> kennedy= presidens.AddFirst("John F Kennedy");
            //taip galima ne tik prideti bet ir issisagoti node vienu metu


            LinkedListNode<string> node = presidens.Find("Richard Nixon");
            //nera labai efektyvu nes reikia eiti per visa lista, bet nera kitos iseities iuo atveju
            //kitas dalykas jei yra pasikartojanciu suras tik pirma
            presidens.AddAfter(node, "Gerard Ford");

            foreach (var item in presidens)
            {
                Console.WriteLine(item);
            }
        }
    }
}
