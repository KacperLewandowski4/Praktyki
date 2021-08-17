using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class Guy
    {
        public string Name;
        public Bet MyBet;
        public int Cash;
        public RadioButton MyRadioButton;
        public Label MyLabel;

        public void DisableRadioButton()
        {
            MyRadioButton.Enabled = false;
        }
        public void EnableRadioButton()
        {
            MyRadioButton.Enabled = true;
        }
        public void UpdateLabels()
        {
            MyRadioButton.Text = Name + " ma " + Cash + " $";
            MyLabel.Text = MyBet.GetDescription();
        }
        public void ClearBet()
        {
            MyBet = null;
        }
        public bool PlaceBet(int betAmount,int DogToWin)
        {
            MyBet = new Bet() { Amount = betAmount, Dog = DogToWin, Bettor = this };
            if (this.MyBet.Bettor.Cash > 5)
            {
                return true;
            }
            else
                return false;
        }
        public void Collect(int Winner)
        {
            this.Cash += MyBet.PayOut(Winner);
        }
    }
}
