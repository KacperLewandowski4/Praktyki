using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Bet
    {
        public int Amount;
        public int Dog;
        public Guy Bettor;

        public string GetDescription()
        {
            if(Bettor.MyBet.Amount == 0)
            {
                return Bettor.Name + " nie obstawił.";
            }
            else
            {
                return Bettor.Name + " obstawił " + Bettor.MyBet.Amount + " na psa nr " + Bettor.MyBet.Dog;
            }

        }
        public int PayOut(int Winner)
        {
            if (Bettor.MyBet.Dog == Winner)
            {
                return Amount;
            }
            else
                return -Amount;
        }
    }
}
