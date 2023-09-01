using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave4_6
{
    internal class ByAgeSorter : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
                return x.Age.CompareTo(y.Age);
        }
    }
}
