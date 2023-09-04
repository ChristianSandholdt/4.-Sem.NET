using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Opgave4_6
{
    internal class Person : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            throw new NotImplementedException();
        }
        public String Name { get; set; }
        public int Age { get; set; }
        public double Weight { get; set; }
        public Person(String name, int age, double weight)
        {
            Name = name;
            Age = age;
            Weight = weight;
        }
        public override String ToString()
        {
            return "Person: " + Name + " Age: " + Age + " Weight: " + Weight;
        }

        public static void printList(List<Person> list)
        {
            foreach (Person p in list)
            {
                Console.WriteLine(p.ToString());
            }
        }


        public void printPersonName (FormatPerson formatPerson)
        {
            Console.WriteLine(formatPerson(Name));
        }
        public delegate string FormatPerson(String name);

    }
}
