using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Reptile DragonLizard = new Reptile(14.0, 72.6, "Herman", "Spain", true);
            Mammal Bear = new Mammal(96.4, 480.2, "Smoky", "Montana", true);

            DragonLizard.GetInfo();
            Bear.GetInfo();
            
            Console.WriteLine(DragonLizard.Sum());
            Console.WriteLine(Bear.Sum());

            Console.WriteLine(DragonLizard.GetWeight(50));
            Console.WriteLine(Bear.GetWeight(100));
        }
    }
}
