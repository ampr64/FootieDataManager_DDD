using Domain.Common;

namespace Domain.Exceptions
{
    public class MoneyCurrencyNullOrEmptyException : DomainException
    {   
        public MoneyCurrencyNullOrEmptyException()
            : base("Money must have currency.")
        {
        }
    }
}
