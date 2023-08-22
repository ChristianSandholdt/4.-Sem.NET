using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave5_6
{
    internal interface IAnimal
    {
        bool isDog();
    }
    class Animal : IAnimal
    {
        public String Species { get; set; }
        public Animal(String species)
        {
            this.Species = species;
        }
        public bool isDog()
        {
            if (this.Species == "dog")
            {
                return true;
            } else
            {
                return false;
            }
        }
    }
}
