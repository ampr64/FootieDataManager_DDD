using Domain.Common;
using Domain.Entities.MatchAggregate;
using System.Collections.Generic;

namespace Domain.Entities.LeagueAggregate
{
    public class Gameweek : ValueObject
    {
        public long SeasonId { get; private set; }

        public IList<Match> Fixtures { get; private set; }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return SeasonId;
            yield return Fixtures;
        }
    }
}
