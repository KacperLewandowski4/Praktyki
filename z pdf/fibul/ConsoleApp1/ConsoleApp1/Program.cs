using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n = 25;
            Fibul liczby = new Fibul();
            Console.WriteLine("Program znajduje rekurencyjnie" +
                n + " pierwszych liczb Fibbonacciego");
            Console.WriteLine();
            for(i = 0; i < n; i++)
            {
                Console.WriteLine(liczby.fib(i) + " ");
            }
            Console.Read();
        }
    }
}
