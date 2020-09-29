namespace Domain.Common
{
    public interface IRepository<T, TId> where T : Entity<TId>, IAggregateRoot
    {
        
    }
}
