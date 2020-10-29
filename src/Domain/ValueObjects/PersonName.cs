using Domain.Rules;
using System.Collections.Generic;

namespace Domain.Common.ValueObjects
{
    public class PersonName : ValueObject
    {
        public string First { get; private set; }

        public string Last { get; private set; }

        public string FullName => $"{First} {Last}";

        private PersonName(string first, string last)
        {
            First = first;
            Last = last;
        }

        public static PersonName Of(string first, string last)
        {
            new PersonNameMustHaveFirstAndLastRule(first, last);
            new PersonNameMustContainAllowedCharactersRule(first, last);

            return new PersonName(first, last); 
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return First;
            yield return Last;
        }

        public override string ToString() => FullName;
    }
}
