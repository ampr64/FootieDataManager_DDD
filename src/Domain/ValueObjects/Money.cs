using Domain.Enums;
using Domain.Exceptions;
using System;

namespace Domain.ValueObjects
{
    public class Money
    {
        private Money(decimal value, string currency)
        {
            Value = value;
            Currency = currency;
        }

        public decimal Value { get; private set; }

        public string Currency { get; private set; }

        public static Money Of(decimal value, string currency)
        {
            if (Enum.TryParse<IsoCurrency>(currency, out var _))
                throw new MoneyInvalidCurrencyFormatException(currency);

            return new Money(value, currency);
        }
    }
}
