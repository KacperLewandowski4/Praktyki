using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Tojkat
    {
        public int trojkat(int n)
        {
            if (n == 1)
                return 1;
            else
                return (n + trojkat(n - 1));
        }
    }
}
