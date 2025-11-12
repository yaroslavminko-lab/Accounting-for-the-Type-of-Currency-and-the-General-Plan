using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting_for_the_Type_of_Currency_and_the_General_Plan
{
    interface IBonusCalculator
    {
        Bonus CalculateBonusFromSell(Sell sell);
    }
}
