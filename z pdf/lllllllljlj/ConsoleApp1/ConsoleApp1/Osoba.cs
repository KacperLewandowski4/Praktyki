using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Osoba
    {
        string nazwisko;
        string imie;
        string ulica;
        string kod;
        string miasto;

        public void wczytaj()
        {
            Console.WriteLine("Wprowadzamy dane");
            Console.WriteLine("==================");
            Console.WriteLine("Podaj nazwisko:");
            nazwisko = Console.ReadLine();
            Console.WriteLine("Podaj imię:");
            imie = Console.ReadLine();
            Console.WriteLine("Podaj ulicę:");
            ulica = Console.ReadLine();
            Console.WriteLine("Podaj kod:");
            kod = Console.ReadLine();
            Console.WriteLine("Podaj miasto:");
            miasto = Console.ReadLine();
            Console.WriteLine();
        }
        public void wyswietl()
        {
            Console.WriteLine("Wyświetlanie danych");
            Console.WriteLine("=====================");
            Console.WriteLine("Nazwisko: " + nazwisko);
            Console.WriteLine("Imię: " + imie);
            Console.WriteLine("Ulica: " + ulica);
            Console.WriteLine("Kod: " + kod);
            Console.WriteLine("Miasto: " + miasto);
        }
    }
}
