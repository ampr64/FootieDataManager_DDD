using Domain.Common;
using Domain.Common.ValueObjects;
using System.Collections.Generic;

namespace Domain.Entities.MatchAggregate
{
    public class Score : ValueObject
    {
        public IList<Goal> HomeGoals { get; private set; }

        public IList<Goal> AwayGoals { get; private set; }

        public override string ToString() =>
            $"{HomeGoals.Count} - {AwayGoals.Count}";

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return HomeGoals;
            yield return AwayGoals;
        }
    }
}
