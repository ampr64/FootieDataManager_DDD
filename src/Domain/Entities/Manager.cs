using Domain.Common;
using System;

namespace Domain.Entities
{
    public class Manager : Person
    {
        public int ClubId { get; private set; }

        public Club Club { get; private set; }

        public Manager(string firstName, string lastName, int countryId, DateTime birthDate, int clubId)
            : base(firstName, lastName, countryId, birthDate)
        {
            ClubId = clubId;
        }
    }
}
