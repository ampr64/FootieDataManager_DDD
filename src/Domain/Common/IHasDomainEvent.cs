using System.Collections.Generic;

namespace Domain.Common
{
    public interface IHasDomainEvent
    {
        IReadOnlyCollection<IDomainEvent> DomainEvents { get; }

        void AddDomainEvent(IDomainEvent domainEvent);

        void ClearDomainEvents();
    }
}
