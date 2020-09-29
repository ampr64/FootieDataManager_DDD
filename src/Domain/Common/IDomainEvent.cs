using System;

namespace Domain.Common
{
    public interface IDomainEvent
    {
        public DateTimeOffset OccurredOn { get; }
    }
}
