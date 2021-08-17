using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 6;
            int[] liczby = new int[n];

            liczby[0] = 57;
            liczby[1] = 303;
            liczby[2] = 34;
            liczby[3] = -1025;
            liczby[4] = 8;
            liczby[5] = 20;
            Sortowanie sort = new Sortowanie();
            sort.czytaj_dane(liczby, n);
            sort.przetworz(liczby, n);
            sort.wynik(liczby, n);
        }
    }
}
