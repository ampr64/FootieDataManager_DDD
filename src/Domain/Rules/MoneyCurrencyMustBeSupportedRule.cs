using Domain.Common;
using Domain.Enumerations;
using Domain.Exceptions;
using System;

namespace Domain.Rules
{
    public class MoneyCurrencyMustBeSupportedRule : IBusinessRule
    {
        private readonly string _currency;

        public MoneyCurrencyMustBeSupportedRule(string currency)
        {
            _currency = currency;
        }

        public void Enforce()
        {
            try
            {
                var _ = Currency.FromName(_currency);
            }
            catch(InvalidOperationException)
            {
                throw new MoneyCurrencyNotSupportedException(_currency);
            }
        }
    }
}
