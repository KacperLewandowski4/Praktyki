using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Osoba pracownik = new Osoba();

            pracownik.wczytaj();
            pracownik.wyswietl();
            Console.Read();
        }
    }
}
