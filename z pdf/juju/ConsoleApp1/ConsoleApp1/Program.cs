using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Trojmian trojmian = new Trojmian();
            trojmian.czytaj_dane();
            trojmian.przetworz_dane();
            trojmian.wyswietl_wynik();
            Console.Read();
        }
    }
}
