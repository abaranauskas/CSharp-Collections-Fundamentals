using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackT
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> books = new Stack<string>();

            books.Push("History X");
            books.Push("Philosophy Book");
            books.Push("Harry Potter");
            books.Push("Math");

            Console.WriteLine("All Books:");
            foreach (var item in books)
            {
                Console.WriteLine(item); //last in - first out
            }

            Console.WriteLine(" ");
            Console.WriteLine("Top Item " +books.Peek()); //neprarandant galima paziureti kas 
            //kas stack virsuje

            Console.WriteLine(" ");
            Console.WriteLine("All Books su POP():");
            while (books.Count >0)
            {
                Console.WriteLine(books.Pop());  //last in - first out
                //su POP isimami ir prarandami elementai is Stack
            }
        }
    }
}
