using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting_for_the_Type_of_Currency_and_the_General_Plan
{
    class Program
    {
        static private ICurrencyConverter converter = new CurrencyConverter();
        static private IBonusCalculator calculator = new BonusCalculator();
        static void Main(string[] args)
        {
            var sells = new List<Sell>
            {
                new Sell(1231200.12m, "Вася", "EUR"),
                new Sell(12, "Олег", "EUR"),
                new Sell(123.5m, "Света", "USD")
            };

            sells = sells.Select(converter.ConvertEurToUSD).ToList();

            var bonuses = sells.Select(calculator.CalculateBonusFromSell).ToList();

            foreach(var bonus in bonuses)
            {
                Console.WriteLine($"Имя: {bonus.Name}, размер бонуса: {bonus.BonusAmount} USD");
            }

            Console.ReadKey();
        }
    }
}
