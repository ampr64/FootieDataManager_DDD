using Domain.Common;
using System;

namespace Domain.Entities.LeagueAggregate
{
    public class Fixture : Entity<long>
    {
        public int LeagueId { get; private set; }

        public DateTime? Schedule { get; private set; }

        public int MyProperty { get; private set; }
    }
}
