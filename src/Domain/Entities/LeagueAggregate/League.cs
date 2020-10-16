using Domain.Common;
using System.Collections.Generic;

namespace Domain.Entities.LeagueAggregate
{
    public class League : Entity<int>, IAggregateRoot
    {
        public string Name { get; private set; }

        public int Division { get; private set; }

        public int NumberOfTeams { get; private set; }

        public int CountryId { get; private set; }

        public Country Country { get; private set; }

        public IList<Club> Clubs { get; private set; }
    }
}
