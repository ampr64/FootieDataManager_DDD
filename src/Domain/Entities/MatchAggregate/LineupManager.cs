using Domain.Common;
using Domain.Common.ValueObjects;
using Domain.Entities.ClubAggregate;
using System.Collections.Generic;

namespace Domain.Entities.MatchAggregate
{
    public class LineupManager : ValueObject
    {
        public long ManagerId { get; private set; }

        public PersonName Name { get; private set; }

        public int ClubId { get; private set; }

        public Club Club { get; private set; }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return ManagerId;
            yield return ClubId;
        }
    }
}
