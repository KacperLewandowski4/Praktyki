using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class ScaryScary : FunnyFunny, IScaryClown
    {
        public ScaryScary(string funnyThingIHave, int numberOfScaryThings)
            : base(funnyThingIHave)
        {
            this.numberOfScaryThings = numberOfScaryThings;
        }
        private int numberOfScaryThings;
        public string ScaryThingIHave
        {
            get
            {
                return "Mam " + numberOfScaryThings + " pajakow";
            }

        }
        public void ScareLittleChildren()
        {
            Console.WriteLine("mamcie");
        }
    }
}
