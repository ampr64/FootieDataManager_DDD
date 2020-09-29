using System;

namespace Domain.Exceptions
{
    public class MoneyMustHaveCurrencyException : Exception
    {
        public MoneyMustHaveCurrencyException()
            : base("Money must have currency.")
        {
        }
    }
}
