using System;

namespace Domain.Exceptions
{
    public class MoneyInvalidCurrencyFormatException : Exception
    {
        public MoneyInvalidCurrencyFormatException(string currency)
            : base($"Currency \"{currency}\" is invalid.")
        {
        }
    }
}
