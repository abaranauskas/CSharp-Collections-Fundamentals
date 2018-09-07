using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObservableCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            var presidents = new ObservableCollection<string>{
                "Jimmy Carter",
                "Ronald Reagan",
                "George HW Bush"
            };

            presidents.CollectionChanged += OnCollectionChanged;

            presidents.Add("Bill Clinton");
            presidents.Remove("Jimmy Carter");

            foreach (var president in presidents)
            {
                Console.WriteLine(president);
            }
        }

        private static void OnCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems!=null)
            {
                foreach (var item in e.NewItems)
                   Console.WriteLine($"Pridetas naujas prezidentas: {item}");

                
            }

            if (e.OldItems != null)
            {
                foreach (var item in e.OldItems)
                    Console.WriteLine($"pasalintas prezidentas {item}");
            }
           

        }

        
    }
}
