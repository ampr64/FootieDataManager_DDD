using Domain.Rules;
using System.Collections.Generic;

namespace Domain.Common.ValueObjects
{
    public class Money : ValueObject
    {
        public decimal Amount { get; private set; }

        public string Currency { get; private set; }

        private Money(decimal amount, string currency)
        {
            Amount = amount;
            Currency = currency;
        }

        public static Money Of(decimal amount, string currency)
        {
            new MoneyMustHaveCurrencyRule(currency).Enforce();
            new MoneyCurrencyMustHaveValidFormatRule(currency).Enforce();
            new MoneyCurrencyMustBeSupportedRule(currency).Enforce();
                
            return new Money(amount, currency);
        }

        public override string ToString() => $"{Currency} {Amount}";

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Amount;
            yield return Currency;
        }
    }
}
