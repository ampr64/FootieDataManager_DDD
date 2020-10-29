using Domain.Common;

namespace Domain.Exceptions
{
    public class MoneyCurrencyNotSupportedException : DomainException
    {
        public MoneyCurrencyNotSupportedException(string currency)
            : base($"{currency} doesn't exist or isn't supported.")
        {
        }
    }
}
