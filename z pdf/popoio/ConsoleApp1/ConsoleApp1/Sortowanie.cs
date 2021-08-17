using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Sortowanie
    {
        public void czytaj_dane(int[] liczby, int n)
        {
            int i;
            Console.Write("Liczby nieposortowane: ");
            for(i = 0; i < n; i++)
            {
                if (i < n - 1)
                    Console.Write(liczby[i] + ", ");
                else
                    Console.Write(liczby[i] + ", ");
            }
            Console.WriteLine();
        }
        public void przetworz(int[] liczby, int n)
        {
            int i, j, x;
            for(i = 1; i <= n - 1; i++)
            {
                for(j = n - 1; j >= i; --j)
                {
                    x = liczby[j - 1];
                    liczby[j - 1] = liczby[j];
                    liczby[j] = x;
                }
            }
        }
        public void wynik(int[] liczby, int n)
        {
            int i;
            Console.WriteLine();
            Console.Write("Liczby posortowane: ");
            for(i = 0; i < n; i++)
            {
                if (i < n - 1)
                    Console.Write(liczby[i] + ", ");
                else
                    Console.Write(liczby[i] + ", ");
            }
            Console.WriteLine();
        }
    }
}
