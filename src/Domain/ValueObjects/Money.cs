using Domain.Exceptions;
using System;

namespace Domain.ValueObjects
{
    public class Money
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
            try
            {
                _ = Enumerations.Currency.FromName(currency);
            }
            catch (InvalidOperationException)
            {
                throw new MoneyInvalidCurrencyFormatException(currency);
            }

            return new Money(value, currency);
        }

        public override string ToString() => $"{Currency} {Value}";
    }
}
