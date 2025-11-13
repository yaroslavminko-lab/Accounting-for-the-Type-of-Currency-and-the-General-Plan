using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting_for_the_Type_of_Currency_and_the_General_Plan
{
    internal class Sell
    {
        private static readonly HashSet<string> allowed = new HashSet<string> { "USD", "EUR" };
        public decimal Amount { get; set; }
        public string Manager { get; set; }
        private string _currency { get; set; }
        public string Currency { get => _currency;
            set
            { 
                if (!allowed.Contains(value.ToUpper()))
                    throw new ArgumentException($"Unsupported currency: {value}");

                _currency = value.ToUpper();
            }
        }

        public Sell(decimal amount, string manager, string currency)
        {
            this.Amount = amount;
            this.Manager = manager ?? string.Empty;
            this.Currency = currency ?? string.Empty;
        } 
    }
}
