using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave4._1
{
    internal static class StringExt
    {
        public static bool lang(this string s, int length)
        {
            if (s.Length > length)
            {
                return true;
            }
            else return false;
        }
    }
}
