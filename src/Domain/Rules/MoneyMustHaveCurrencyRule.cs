using Domain.Common;
using Domain.Exceptions;

namespace Domain.Rules
{
    public class MoneyMustHaveCurrencyRule : IBusinessRule
    {
        private readonly string _currency;

        public MoneyMustHaveCurrencyRule(string currency)
        {
            _currency = currency;
        }

        public void Enforce()
        {
            if (string.IsNullOrEmpty(_currency))
                throw new MoneyCurrencyNullOrEmptyException();
        }
    }
}
