using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            ScaryScary fingersTheClown = new ScaryScary("duze buty", 35);
            FunnyFunny someFunnyClown = fingersTheClown;
            IScaryClown someOtherScaryClown = someFunnyClown as ScaryScary;
            someFunnyClown.Honk();
            Console.ReadKey();
        }
    }
  
}
