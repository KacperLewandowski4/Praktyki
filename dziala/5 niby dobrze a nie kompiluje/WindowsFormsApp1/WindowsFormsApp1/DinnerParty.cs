using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class DinnerParty
    {
        public const int CostOfFoodPerPerson = 25;
        public int NumberOfPeople;
        public decimal CostOfBeveragesPerPerson;
        public decimal CostOfDecorations = 0;
        
        public void SetHealthyOption(bool healthyOption)
        {
            if (healthyOption)
            {
                CostOfBeveragesPerPerson = 5.00M;
            }
            else
            {
                CostOfBeveragesPerPerson = 20.00M;
            }
        }

        public void CalculateCostOfDecorations(bool fancy)
        {
            if (fancy)
                CostOfDecorations = (NumberOfPeople * 15.00M) + 50M;
            else
                CostOfDecorations = (NumberOfPeople * 7.50M) + 30M;
        }
        public decimal CalculateCost(bool healthyOption)
        {
            decimal totalCost = CalculateCostOfDecorations + ((CostOfBeveragesPerPerson + CostOfFoodPerPerson) * NumberOfPeople);
            if (healthyOption)
                return totalCost * .95M;
            else
                return totalCost;
        }
    }
}
