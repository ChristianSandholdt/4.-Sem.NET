using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave4._3
{
    internal static class FactorialOpgave
    {
        public static int factorial(this int x)
        {
            if (x == 0) return 1;

            return x * factorial(x - 1);
        }
    }
}
