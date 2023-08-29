using Opgave3;
using System.Collections;
using System.Diagnostics.CodeAnalysis;

Fibonacci fib = new Fibonacci();


while (true)
{
    int sum = 0;
    Console.WriteLine("Enter a number");
    String input = Console.ReadLine();
    int tal = int.Parse(input);


    if (tal == 0)
    {
        return;
    }

    int[] Array = new int[tal];


    for (int i = 0; i < tal; i++)
    {
        Console.WriteLine(fib.fibo(i));
        Array[i] = fib.fibo(i);
    }

    fib.printList(tal, Array);
    Console.WriteLine(String.Join(" ", fib.printList(tal,Array)));

    foreach (var item in Array)
    {
        sum += item;
    }
    Console.WriteLine(sum);


}

