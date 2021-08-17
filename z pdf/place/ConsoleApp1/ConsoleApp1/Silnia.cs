using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Silnia
    {
        public long silna(int liczba)
        {
            long zwrot = 1;
            if(liczba >= 2)
            {
                zwrot = liczba * silna(liczba - 1);
            }
            return zwrot;
        }
    }
}
