using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueT
{
    class Program
    {
        static void Main(string[] args)
        {

            //Queue - first in first out

            Queue<string> tasks = new Queue<string>();

            tasks.Enqueue("Do the dish washing");
            tasks.Enqueue("Finish c# collection course");
            tasks.Enqueue("Buy some coffee");
            tasks.Enqueue("Buy some more coffee");

            string peek = tasks.Peek(); //neprarandant randamas pirmas eileje taskas
            Console.WriteLine("Nemodifikuojant pirmas eileje randamas su Peek() metodu : " + peek);

            Console.WriteLine("");
            Console.WriteLine("All task:");
            foreach (var task in tasks)
            {
                Console.WriteLine(task); //FIFO. cia neprarandamas 
            }


            Console.WriteLine("");
            var peekDeq = tasks.Dequeue();
            Console.WriteLine("Modifikuojant(isimant is eiles) pirmas eileje randamas su Dequeue() metodu : " + peekDeq);


            Console.WriteLine("");
            Console.WriteLine("All task po Dequeue():");
            foreach (var task in tasks)
            {
                Console.WriteLine(task); //FIFO. cia neprarandamas 
            }


        }
    }
}
