using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting_for_the_Type_of_Currency_and_the_General_Plan
{
    class CurrencyConverter : ICurrencyConverter
    {
        public Sell ConvertEurToUSD(Sell sell)
        {
            return new Sell(sell.Amount * 1.1m, sell.Manager, "USD");
        }
    }
}
