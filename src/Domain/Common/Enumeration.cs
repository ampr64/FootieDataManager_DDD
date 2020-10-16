using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Domain.Common
{
    public abstract class Enumeration<TEnumeration> :
        Enumeration<TEnumeration, int>
        where TEnumeration : Enumeration<TEnumeration, int>
    {
        protected Enumeration(int value, string name) : base(value, name)
        {
        }
    }


    public abstract class Enumeration<TEnumeration, TValue> :
        IEquatable<Enumeration<TEnumeration, TValue>>,
        IComparable<Enumeration<TEnumeration, TValue>>
        where TEnumeration : Enumeration<TEnumeration, TValue>
        where TValue : IEquatable<TValue>, IComparable<TValue>
    {
        public TValue Value { get; }

        public string Name { get; }

        protected Enumeration(TValue value, string name)
        {
            if (string.IsNullOrEmpty(name))
                new ArgumentException($"{nameof(name)} cannot be null or empty.");
            if (value == null)
                new ArgumentNullException($"{nameof(value)} cannot be null.");

            Value = value;
            Name = name;
        }

        public Type GetValueType() => typeof(TValue);

        public override string ToString() => Name.ToString();

        public static IReadOnlyCollection<TEnumeration> All() =>
            typeof(TEnumeration).GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.DeclaredOnly)
                .Select(f => f.GetValue(null))
                .Cast<TEnumeration>()
                .ToList()
                .AsReadOnly();

        public static TEnumeration FromValue(TValue value) =>
            Parse(value, nameof(value), item => item.Value.Equals(value));

        public static TEnumeration FromName(string name) =>
            Parse(name, nameof(name), item => item.Name.Equals(name, StringComparison.InvariantCultureIgnoreCase));

        public static bool operator ==(Enumeration<TEnumeration, TValue> left, Enumeration<TEnumeration, TValue> right)
        {
            if (left is null)
                return right is null;

            return left.Equals(right);
        }

        public static bool operator !=(Enumeration<TEnumeration, TValue> left, Enumeration<TEnumeration, TValue> right) =>
            !(left == right);

        public override bool Equals(object obj) =>
            (obj is Enumeration<TEnumeration, TValue> other) && Equals(other);

        public virtual bool Equals(Enumeration<TEnumeration, TValue> other)
        {
            if (ReferenceEquals(this, other))
                return true;

            if (other is null)
                return false;

            return Value.Equals(other.Value);
        }

        public virtual int CompareTo(Enumeration<TEnumeration, TValue> other) =>
            Value.CompareTo(other.Value);

        public override int GetHashCode() => Value.GetHashCode();

        public static bool operator <(Enumeration<TEnumeration, TValue> left, Enumeration<TEnumeration, TValue> right) =>
            left.CompareTo(right) < 0;

        public static bool operator <=(Enumeration<TEnumeration, TValue> left, Enumeration<TEnumeration, TValue> right) =>
            left.CompareTo(right) <= 0;

        public static bool operator >(Enumeration<TEnumeration, TValue> left, Enumeration<TEnumeration, TValue> right) =>
            left.CompareTo(right) > 0;

        public static bool operator >=(Enumeration<TEnumeration, TValue> left, Enumeration<TEnumeration, TValue> right) =>
            left.CompareTo(right) >= 0;

        public static implicit operator TValue(Enumeration<TEnumeration, TValue> enumeration) =>
            enumeration.Value;

        public static explicit operator Enumeration<TEnumeration, TValue>(TValue value) =>
            FromValue(value);

        protected static TEnumeration Parse<TProperty>(TProperty propertyValue, string propertyName, Func<TEnumeration, bool> predicate) =>
            All().FirstOrDefault(predicate)
            ?? throw new InvalidOperationException($"'{propertyValue}' is not a valid {propertyName} in {typeof(TEnumeration).Name}");
    }
}
