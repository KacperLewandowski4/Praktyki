using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Fibul
    {
        public int fib(int n)
        {
            switch(n)
            {
                case 0: return 0;
                    break;
                case 1: return 1;
                    break;
                default: return fib(n - 1) + fib(n - 2);
            }
        }
    }
}
