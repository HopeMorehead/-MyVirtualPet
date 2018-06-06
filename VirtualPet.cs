using System.Collections.Generic;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyVirtualPet
{
    class VirtualPet

    {
        internal string Name     {get; set;}
        internal string Color    {get; set;}
        internal string Species  {get; set;}
        internal int HungerLevel {get; set;}
        internal int EnergyLevel {get; set;}


     

        internal VirtualPet()
        {

        }
    
        internal VirtualPet(string Name,string Color, string Species,int HungerLevel)
        {
            this.Name = Name;
            this.Color = Color;
            this.Species = Species;
            this.HungerLevel = HungerLevel;
        }



        public int Feed()
        {
            HungerLevel += 5;

            return HungerLevel;
        }
        public void Play()
        {
            HungerLevel -= 5;
            EnergyLevel += 10;
            Console.WriteLine($"{Name} Hunger:{HungerLevel}");
            Console.WriteLine($"{Name} Hunger:{EnergyLevel}");            

        }
    }
}
