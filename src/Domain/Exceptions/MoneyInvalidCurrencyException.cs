using Domain.Common;

namespace Domain.Exceptions
{
    public class MoneyInvalidCurrencyException : DomainException
    {
        public MoneyInvalidCurrencyException(string currency)
            : base($"Currency \"{currency}\" is not valid. " +
                  $"It must be three letters in compliance with the ISO 4217 Standard.")
        {
        }
    }
}
