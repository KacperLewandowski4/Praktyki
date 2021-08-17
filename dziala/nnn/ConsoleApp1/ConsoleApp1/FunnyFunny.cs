using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class FunnyFunny : IClown
    {
        public FunnyFunny(string funnyThingIHave)
        {
            this.funnyThingIHave = funnyThingIHave;
        }
        private string funnyThingIHave;
        public string FunnyThingIHave
        {
            get
            {
                return "Czesc mam " + funnyThingIHave;
            }
        }
        public void Honk()
        {
            Console.WriteLine(this.FunnyThingIHave);
        }
    }
}
