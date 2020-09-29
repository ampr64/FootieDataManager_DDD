using Domain.Common;
using System;

namespace Domain.Entities
{
    public class Owner : Person
    {
        public Club OwnedClub { get; private set; }

        public Owner(string firstName, string lastName, int countryId, DateTime birthDate)
            : base(firstName, lastName, countryId, birthDate)
        {
        }
    }
}
