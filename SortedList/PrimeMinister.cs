using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedList
{
    class PrimeMinister
    {
        public PrimeMinister(string name, int yearElected)
        {
            Name = name;
            YearElected = yearElected;

        }

        public override string ToString()
        {
            return $"{Name}, elected: {YearElected}";
        }


        public string Name { get; private set; }
        public int YearElected { get; private set; }
    }
}
