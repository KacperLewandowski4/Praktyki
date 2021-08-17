using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, pole;

            Console.WriteLine("Program oblicza polo prost");
            Console.WriteLine("podaj a ");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("podaj b ");
            b = double.Parse(Console.ReadLine());

            pole = a * b;
            Console.WriteLine("pole porstakata to {0}", pole);
            Console.Read();
        }
    }
}
