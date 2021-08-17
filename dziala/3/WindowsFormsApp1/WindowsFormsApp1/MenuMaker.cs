using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class MenuMaker
    {
        public Random Randomizer;

        string[] Meats = { "wołowina", "salami", "indyk" };
        string[] Condiments = { "musztarda", "majonez", "ketchup" };
        string[] Breads = { "chleb", "bułka" };

        public string GetMenuItem()
        {
            string randomMeat = Meats[Randomizer.Next(Meats.Length)];
            string randomCondiment = Condiments[Randomizer.Next(Condiments.Length)];
            string randomBread = Breads[Randomizer.Next(Breads.Length)];
            return randomMeat + "," + randomCondiment + "," + randomBread;
        }
    }

}
