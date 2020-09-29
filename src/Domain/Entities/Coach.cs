using Domain.Common;
using System;

namespace Domain.Entities
{
    public class Coach : Person
    {
        public int ClubId { get; private set; }

        public Club Club { get; private set; }

        public Coach(string firstName, string lastName, int countryId, DateTime birthDate, int clubId)
            : base(firstName, lastName, countryId, birthDate)
        {
            ClubId = clubId;
        }
    }
}
