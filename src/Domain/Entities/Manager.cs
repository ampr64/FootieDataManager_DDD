using Domain.Common;
using Domain.Common.ValueObjects;
using Domain.Entities.ClubAggregate;
using System;

namespace Domain.Entities
{
    public class Manager : Person
    {
        public int ClubId { get; private set; }

        public Club Club { get; private set; }

        public Manager(PersonName name, int countryId, decimal height, decimal weight, DateTime birthDate, int clubId)
            : base(name, countryId, height, weight, birthDate)
        {
            ClubId = clubId;
        }
    }
}
