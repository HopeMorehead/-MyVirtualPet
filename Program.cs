using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyVirtualPet
{
    class Program
    {
        static void Main(string[] args)
        {
            
            VirtualPet dog = new VirtualPet("Bob","Gold","dog",200);
            VirtualPet cat = new VirtualPet();
            Console.WriteLine(dog.Feed());
            Console.WriteLine(dog.Feed());
               dog.Play();


            // can't be done  Console.WriteLine( dog.Hungry());
        }
    }
}
