using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n = 10;

            Tojkat liczby = new Tojkat();

            Console.WriteLine("Program znajduje " + n +
                " pierwszych liczb trójkątnych");
            Console.WriteLine();
            for(i = 1; i <= n; i++)
            {
                Console.WriteLine("#" + i + " = " + liczby.trojkat(i));
            }
            Console.Read();
        }
    }
}
