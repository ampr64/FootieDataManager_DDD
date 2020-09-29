using Domain.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Domain.Common
{
    public abstract class ValueObject : IEquatable<ValueObject>
    {
        private List<PropertyInfo> _properties;
        private List<FieldInfo> _fields;

        public static bool operator ==(ValueObject left, ValueObject right)
        {
            if (left is null ^ right is null)
                return false;

            return left?.Equals(right) != false;
        }

        public static bool operator !=(ValueObject left, ValueObject right) =>
            !(left == right);

        public bool Equals(ValueObject other) =>
            Equals(other as object);

        public static bool Equals(ValueObject left, ValueObject right) =>
            left?.Equals(right) ?? right is null;

        public override bool Equals(object obj)
        {
            if (obj is null || !obj.IsSameTypeAs(this))
                return false;

            return GetProperties().All(p => AreEqual(obj, p))
            && GetFields().All(f => AreEqual(obj, f));
        }

        public override int GetHashCode() =>
            GetProperties().Select(p => p.GetValue(this) != null ? p.GetHashCode() : 0)
            .Concat(GetFields().Select(f => f.GetValue(this) != null ? f.GetHashCode() : 0))
            .Aggregate((x, y) => x ^ y);

        private bool AreEqual(object obj, PropertyInfo property) =>
            Equals(property.GetValue(this), property.GetValue(obj));

        private bool AreEqual(object obj, FieldInfo field) =>
            Equals(field.GetValue(this), field.GetValue(obj));

        private IEnumerable<PropertyInfo> GetProperties() =>
            _properties ??= GetType()
            .GetProperties(BindingFlags.Public | BindingFlags.Instance)
            .Where(p => p.GetCustomAttribute<IgnoreMemberAttribute>() is null)
            .ToList();

        private IEnumerable<FieldInfo> GetFields() =>
            _fields ??= GetType()
            .GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance)
            .Where(f => f.GetCustomAttribute<IgnoreMemberAttribute>() is null)
            .ToList();
    }
}
