using System;

namespace Domain.Common
{
    public abstract class DomainException : Exception
    {
        protected DomainException(string message)
            : base(message)
        {
        }
    }
}
