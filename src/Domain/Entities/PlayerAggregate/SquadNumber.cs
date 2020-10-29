using Domain.Common;
using Domain.Rules;
using System.Collections.Generic;

namespace Domain.Entities.PlayerAggregate
{
    public class SquadNumber : ValueObject
    {
        public int Number { get; private set; }

        private SquadNumber(int number) => Number = number;

        public SquadNumber Of(int number)
        {
            new SquadNumberMustBeWithinRangeRule(number).Enforce();

            return new SquadNumber(number);
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Number;
        }

        public override string ToString() => Number.ToString();
    }
}
