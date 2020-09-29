using System;

namespace Domain.Common
{
    public abstract class DomainEvent : IDomainEvent
    {
        public DomainEvent() => OccurredOn = DateTimeOffset.UtcNow;

        public DateTimeOffset OccurredOn { get; }
    }
}
