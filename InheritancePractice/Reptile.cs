using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePractice
{
    class Reptile : Species
    {
        public Reptile(double weight, double height, string name, string habitat, bool hasTail)
        {
            this.Weight = weight;
            this.Height = height;
            this.Name = name;
            this.Habitat = habitat;
            this.HasTail = hasTail;
        }
    }
}
