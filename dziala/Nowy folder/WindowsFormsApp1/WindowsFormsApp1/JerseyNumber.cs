using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class JerseyNumber
    {
        public string Player { get; set; }
        public int YearRetired { get; private set; }
        public JerseyNumber(string player, int numberRetired)
        {
            Player = player;
            YearRetired = numberRetired;
        }
    }
}
