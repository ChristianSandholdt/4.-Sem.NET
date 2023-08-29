using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave3
{
    internal class Fibonacci
    {
        public Fibonacci() { }

        public int fibo(int n)
        {
            if (n <= 0)
            {
                return 0;
            }
            if (n == 1)
            {
                return n;
            }
            int tal = fibo(n - 1) + fibo(n - 2);
            return tal;
        }

        
        public int[] printList(int n, int[] array)
        {
            for (int i = 0; i < n; i++)
            {
                array[i] = fibo(i);
            }
            return array;
        }
   
    }
}
