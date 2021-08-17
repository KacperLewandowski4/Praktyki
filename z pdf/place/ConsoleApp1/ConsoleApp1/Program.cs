using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n;
            Silnia s = new Silnia();

            Console.WriteLine("podaj n: ");
            n = int.Parse(Console.ReadLine());

            for(i = 1; i <= n; i++)
            {
                Console.WriteLine(" " + i + "! = " + s.silna(i));
            }
            Console.Read();
        }
    }
}
