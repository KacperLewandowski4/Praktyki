using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int rozmiar = 10;
            double[,] tablica = new double[rozmiar, rozmiar];
            Macierz macierz1 = new Macierz();

            macierz1.czytaj_dane(tablica, rozmiar);
            macierz1.przetworz_dane(tablica, rozmiar);
            macierz1.wyswietl_wynik(tablica, rozmiar);
            Console.Read();
        }
    }
}
