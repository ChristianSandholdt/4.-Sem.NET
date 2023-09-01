using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave4._4
{
    internal static class PowerOf
    {
        public static int Power(this int number, int power)
        {
            Console.WriteLine((int)Math.Pow(number, power));
            return (int)Math.Pow(number, power);
        }
    }
}
