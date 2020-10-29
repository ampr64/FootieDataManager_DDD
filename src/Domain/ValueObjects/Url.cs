using Domain.Rules;
using System.Collections.Generic;

namespace Domain.Common.ValueObjects
{
    public class Url : ValueObject
    {
        public string Value { get; private set; }

        private Url(string value) => Value = value;

        public static Url Of(string url)
        {
            new UrlMustBeHttpOrHttpsRule(url);

            return new Url(url);
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }

        public override string ToString() => Value.ToString();
    }
}
