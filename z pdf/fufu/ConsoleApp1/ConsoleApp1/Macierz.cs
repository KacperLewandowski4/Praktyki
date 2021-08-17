using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Macierz
    {
        public void czytaj_dane(double[,] macierz, int rozmiar)
        {
            int i, j;
            Random random = new Random();
            for(i=0; i < rozmiar; i++)
            {
                for(j=0; j < rozmiar; j++)
                {
                    if (i == j)
                        macierz[i, j] = Math.Round(9 * (random.NextDouble()));
                    else
                        macierz[i, j] = 0;
                }
            }
        }
        public void przetworz_dane(double[,] macierz, int rozmiar)
        {
            int i;
            double suma = 0;
            for (i = 0; i < rozmiar; i++)
                suma = suma + macierz[i, i];
            Console.WriteLine("Suma elementów na przekątnej = " + suma);
            Console.WriteLine();
        }
        public void wyswietl_wynik(double[,] macierz, int rozmiar)
        {
            int i, j;
            for(i = 0; i < rozmiar; i++)
            {
                for (j = 0; j < rozmiar; j++)
                {
                    Console.Write(macierz[i, j] + " ");
                }               
            }
            Console.WriteLine();
        }
    }
}
