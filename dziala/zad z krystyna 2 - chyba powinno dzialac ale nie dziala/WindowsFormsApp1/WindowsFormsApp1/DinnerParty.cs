using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class DinnerParty : Party
    {
        public bool HealthyOption  { get; set; };

        public DinnerParty (int numberOfPeople, bool healthyOption, bool fancyDecorations)
        {
            NumberOfPeople = numberOfPeople;
            FancyDecorations = fancyDecorations;
            HealthyOption = healthyOption;
        }
        /*
        private decimal CalculateCostOfDecorations()
        {
            decimal costOfDecorations;
            if (FancyDecorations)
            {
                costOfDecorations = (NumberOfPeople * 15.00M) + 50M;
            }
            else
            {
                costOfDecorations = (NumberOfPeople * 7.50M) + 30M;
            }
            return costOfDecorations;
        }*/
        public decimal CalculateCostOfBeveragesPerPerson()
        {
            decimal costOfBeveragesPerPerson;
            if(HealthyOption)
            {
                costOfBeveragesPerPerson = 5.00M;
            }
            else
            {
                costOfBeveragesPerPerson = 20.00M;
            }
            return costOfBeveragesPerPerson;
        }
        override public decimal Cost
        {
            get
            {
                decimal totalCost = base.Cost;
                totalCost += ((CalculateCostOfBeveragesPerPerson()  * NumberOfPeople);
                if(HealthyOption)
                {
                    totalCost *= .95M;
                }
                return totalCost;
            }
        }
    }
}
