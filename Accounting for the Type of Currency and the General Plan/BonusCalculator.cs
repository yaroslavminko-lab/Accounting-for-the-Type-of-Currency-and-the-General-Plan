using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting_for_the_Type_of_Currency_and_the_General_Plan
{
    class BonusCalculator : IBonusCalculator
    {
        public Bonus CalculateBonusFromSell(Sell sell)
        {
            return new Bonus(
                sell.Manager,
                Math.Round(sell.Amount * 0.013m + (sell.Amount > 750000 ? sell.Amount * 0.005m : 0), 2)
            );
        }
    }
}
