using Domain.Common;
using Domain.Exceptions;
using System.Linq;

namespace Domain.Rules
{
    public class MoneyCurrencyMustHaveValidFormatRule : IBusinessRule
    {
        private readonly string _currency;

        public MoneyCurrencyMustHaveValidFormatRule(string currency)
        {
            _currency = currency;
        }

        public void Enforce()
        {
            if (_currency.Length != 3 || _currency.Any(_ => !char.IsLetter(_)))
                throw new MoneyInvalidCurrencyException(_currency);
        }
    }
}
