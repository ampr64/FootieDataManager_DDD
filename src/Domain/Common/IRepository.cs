using System;

namespace Domain.Common
{
    public interface IRepository<T, TId> where T : Entity<TId>, IAggregateRoot
        where TId : IEquatable<TId>
    {
        
    }
}
