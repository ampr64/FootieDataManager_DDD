using Domain.Common;
using Domain.Common.ValueObjects;
using Domain.Entities.LeagueAggregate;
using System;

namespace Domain.Entities
{
    public class Referee : Person
    {
        public int LeagueId { get; private set; }

        public League League { get; private set; }

        public Referee(PersonName name, int countryId, decimal height, decimal weight,
            DateTime birthDate, int leagueId) : base(name, countryId, height, weight, birthDate)
        {
            LeagueId = leagueId;
        }
    }
}
