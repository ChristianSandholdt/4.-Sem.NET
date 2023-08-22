using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave3_4
{
    internal class Person
    {
        public String Name { get; set; }

        public Person(String name)
        {
            this.Name = name;
        }

        public override string ToString()
        {
            return "Name is: " + this.Name;
        }

    }
}
