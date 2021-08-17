using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Trojmian
    {
        double a, b, c, delta, x1, x2;
        byte liczba_pierwiastkow;
        public void czytaj_dane()
        {
            Console.WriteLine("Podaj a: ");
            a = double.Parse(Console.ReadLine());
            if (a == 0)
            {
                Console.WriteLine("BŁĄD");
                Console.Read();
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Podaj b: ");
                b = double.Parse(Console.ReadLine());
                Console.WriteLine("Podaj c: ");
                c = double.Parse(Console.ReadLine());
            }
        }
        public void przetworz_dane()
        {
            delta = b * b - 4 * a * c;
            if (delta < 0)
            {
                liczba_pierwiastkow = 0;
            }
            if (delta == 0)
            {
                liczba_pierwiastkow = 1;
            }
            if (delta > 0)
            {
                liczba_pierwiastkow = 2;
            }
            switch (liczba_pierwiastkow)
            {
                case 1:
                    x1 = -b / (2 * a);
                    break;
                case 2:
                    {
                        x1 = (-b - Math.Sqrt(delta)) / (2 * a);
                        x2 = (-b + Math.Sqrt(delta)) / (2 * a);
                    }
                    break;
            }
        }
        public void wyswietl_wynik()
        {
            Console.WriteLine("Dla a= {0:##.##}", a);
            Console.WriteLine("Dla b= {0:##.##}", b);
            Console.WriteLine("Dla c= {0:##.##}", c);

            switch (liczba_pierwiastkow)
            {
                case 0:
                    Console.WriteLine("brak pierwiastków");
                    break;
                case 1:
                    Console.WriteLine("1 pierwiastek x1= {0:##.##}", x1);
                    break;
                case 2:
                    Console.WriteLine("2 pierwiastki x1= {0:##.##}", x1);
                    Console.WriteLine("x2= {0:##.##}", x2);
                    break;
            }
        }
    }
}
