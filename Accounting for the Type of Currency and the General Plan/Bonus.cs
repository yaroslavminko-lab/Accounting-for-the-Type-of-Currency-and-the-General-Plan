using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting_for_the_Type_of_Currency_and_the_General_Plan
{
    class Bonus
    {
        public string Name { get; set; }
        public decimal BonusAmount { get; set; }

        public Bonus(string name, decimal bonusAmount)
        {
            this.Name = name ?? string.Empty;
            this.BonusAmount = bonusAmount;
        }
    }
}
