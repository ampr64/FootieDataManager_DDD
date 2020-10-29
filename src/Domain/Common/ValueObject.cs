using Domain.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Domain.Common
{
    public abstract class ValueObject : IEquatable<ValueObject>, ICloneable
    {
        public static bool operator ==(ValueObject left, ValueObject right)
        {
            if (left is null ^ right is null)
                return false;

            return left?.Equals(right) != false;
        }

        public static bool operator !=(ValueObject left, ValueObject right) =>
            !(left == right);

        public bool Equals(ValueObject other) => Equals(other as object);

        public static bool Equals(ValueObject left, ValueObject right) =>
            left?.Equals(right) ?? right is null;

        public override bool Equals(object obj)
        {
            if (!obj.IsSameTypeAs(this))
                return false;

            return GetEqualityComponents()
                .SequenceEqual(((ValueObject)obj).GetEqualityComponents());
        }

        protected abstract IEnumerable<object> GetEqualityComponents();

        public override int GetHashCode() =>
            GetEqualityComponents()
            .Select(c => c != null ? c.GetHashCode() : 0)
            .Aggregate((x, y) => x ^ y);

        public object Clone() => MemberwiseClone();

        public ValueObject GetCopy() => MemberwiseClone() as ValueObject;
    }
}
