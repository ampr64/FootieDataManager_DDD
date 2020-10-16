using Domain.Common;
using System.Collections.Generic;

namespace Domain.ValueObjects
{
    public class Points : ValueObject
    {
        public int Value { get; private set; }

        private Points(int value) => Value = value;

        public static Points Win() => new Points(3);

        public static Points Loss() => new Points(0);

        public static Points Draw() => new Points(1);

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }

        public override string ToString() => Value.ToString();
    }
}
