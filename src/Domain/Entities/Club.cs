using Domain.Common;
using System.Collections.Generic;

namespace Domain.Entities
{
    public class Club : AuditableEntity<int>, IAggregateRoot
    {
        public int LeagueId { get; private set; }

        public League League { get; private set; }

        public long OwnerId { get; private set; }

        public Owner Owner { get; private set; }

        public long ManagerId { get; private set; }

        public Coach Manager { get; private set; }

        public IList<Player> Squad { get; private set; }
    }
}
