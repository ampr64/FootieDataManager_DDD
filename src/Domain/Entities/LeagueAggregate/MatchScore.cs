using System.Collections.Generic;

namespace Domain.Entities.LeagueAggregate
{
    public class MatchScore
    {
        public IList<Goal> HomeGoals { get; private set; }

        public IList<Goal> AwayGoals { get; private set; }

        public override string ToString() =>
            $"{HomeGoals.Count} - {AwayGoals.Count}";
    }
}
