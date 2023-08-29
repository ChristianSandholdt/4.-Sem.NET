using System;
using System.Collections;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

public class Fibonacci
{
    ArrayList numbers<int> = new ArrayList();

    static void Main(string[] args)
    {
        int amount = 0;

        for (int i = 0; i < amount; i++) {
            Console.WriteLine(NumberStyles[i] + " ")
        }

    }

    public int add(int n)
    {
        if (number <= 1)
        {
            return number
        }

        if (numbers[n] != 0)
        {
            return numbers[n]
        }

        int nthNumber = (fibonacci(n - 1) + (fibonacci(n - 2)));
        fibonacciCache[n] = nthNumber;

        return nthNumber;

    }



}
