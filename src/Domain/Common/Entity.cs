using System;

namespace Domain.Common
{
    public abstract class Entity<TId> : IEquatable<Entity<TId>>
        where TId : IEquatable<TId>
    {
        public TId Id { get; protected set; }

        public static bool operator ==(Entity<TId> left, Entity<TId> right)
        {
            if (left is null)
                return right is null;

            return left.Equals(right);
        }

        public static bool operator !=(Entity<TId> left, Entity<TId> right) => !(left == right);

        public bool IsTransient() => Id.Equals(default);

        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Entity<TId> other))
                return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        public bool Equals(Entity<TId> other) =>
            other != null
            && Id.Equals(other.Id)
            && !IsTransient();

        public override int GetHashCode() =>
            Id.GetHashCode();
    }
}
