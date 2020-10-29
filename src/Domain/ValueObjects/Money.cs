using Domain.Rules;
using System.Collections.Generic;

namespace Domain.Common.ValueObjects
{
    public class Money : ValueObject
    {
        public decimal Value { get; private set; }

        public string Currency { get; private set; }

        private Money(decimal value, string currency)
        {
            Value = value;
            Currency = currency;
        }

        public static Money Of(decimal value, string currency)
        {
            new MoneyMustHaveCurrencyRule(currency).Enforce();
            new MoneyCurrencyMustHaveValidFormatRule(currency).Enforce();
            new MoneyCurrencyMustBeSupportedRule(currency).Enforce();

            return new Money(value, currency);
        }

        public override string ToString() => $"{Currency} {Value}";

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Currency;
            yield return Value;
        }
    }
}
