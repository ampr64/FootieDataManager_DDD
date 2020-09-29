using Domain.Common;
using System;

namespace Domain.Entities
{
    public class Referee : Person
    {
        public int LeagueId { get; private set; }

        public League League { get; private set; }

        public Referee(string firstName, string lastName, int countryId, DateTime birthDate, int leagueId)
            : base(firstName, lastName, countryId, birthDate)
        {
            LeagueId = leagueId;
        }
    }
}
