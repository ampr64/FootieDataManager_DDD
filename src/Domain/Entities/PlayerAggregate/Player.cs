using Domain.Common;
using Domain.Entities.ClubAggregate;
using Domain.Common.ValueObjects;
using System;

namespace Domain.Entities.PlayerAggregate
{
    public class Player : Person, IAggregateRoot
    {
        public int? ClubId { get; private set; }

        public Club Club { get; private set; }

        public Foot Foot { get; private set; }

        public Position Position { get; private set; }

        public SquadNumber SquadNumber { get; private set; }

        public Money MarketValue { get; private set; }

        public Player(PersonName name, int countryId, decimal height, decimal weight, DateTime birthDate,
            Foot foot, Position position, SquadNumber squadNumber, Money marketValue, int? clubId = null)
            : base(name, countryId, height, weight, birthDate)
        {
            ClubId = clubId;
            Foot = foot;
            Position = position;
        }

        public void ChangeClub(int? clubId)
        {
            ClubId = clubId;
        }

        public void UpdateSquadNumber(SquadNumber squadNumber)
        {
            SquadNumber = squadNumber;
        }
    }
}
