using Domain.Common;
using Domain.Entities.LeagueAggregate;
using Domain.Entities.PlayerAggregate;
using System.Collections.Generic;

namespace Domain.Entities.ClubAggregate
{
    public class Club : AuditableEntity<int>, IAggregateRoot
    {
        public string Name { get; private set; }

        public int LeagueId { get; private set; }

        public League League { get; private set; }

        public string Owner { get; private set; }

        public long? ManagerId { get; private set; }

        public Manager Manager { get; private set; }

        public int? StadiumId { get; private set; }

        public Stadium Stadium { get; private set; }

        public int YearFounded { get; private set; }

        public IList<Player> Squad { get; private set; }
    }
}
