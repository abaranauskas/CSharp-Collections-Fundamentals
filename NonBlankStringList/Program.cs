using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonBlankStringList
{
    class Program
    {
        static void Main(string[] args)
        {
            NonBlankStringList list = new NonBlankStringList();

            list.Add("Item added to index 0");
            list[0] = "   ";
            list.Add("Item added to index 1");
            list.Insert(2, "Item added to index 2");

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

        }
    }
}
