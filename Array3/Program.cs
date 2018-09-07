using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array3
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] people = {
                new Person {Name="Aidas", Age = 31 },
                new Person {Name="Bill", Age = 21 }
            };


            foreach (Person person in people)
            {
                person.Age = 20; //modifikuoti masyvo elemento elementa galima
                //person = new Person(); // bet pascio elemento ne
            }

            foreach (Person person in people)
            {
                Console.WriteLine(person);
            }
        }


    }

    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"{Name}, {Age}";
        }
    }
}
