using Domain.Common;
using Domain.Exceptions;
using System.Collections.Generic;

namespace Domain.ValueObjects
{
    public class SquadNumber : ValueObject
    {
        public int Value { get; private set; }

        private SquadNumber(int number) => Value = number;

        public SquadNumber Of(int number)
        {
            if (number < 1 || number > 99)
                throw new SquadNumberInvalidException(number);

            return new SquadNumber(number);
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }

        public override string ToString() => Value.ToString();
    }
}
