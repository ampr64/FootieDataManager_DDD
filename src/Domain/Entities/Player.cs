using Domain.Common;
using Domain.Enumerations;
using Domain.ValueObjects;
using System;

namespace Domain.Entities
{
    public class Player : Person, IAggregateRoot
    {
        public int? ClubId { get; private set; }

        public Club Club { get; private set; }

        public decimal Height { get; private set; }

        public decimal Weight { get; private set; }

        public Foot Foot { get; private set; }

        public Position Position { get; private set; }

        public SquadNumber SquadNumber { get; private set; }

        public Money YearlySalary { get; private set; }

        public Money MarketValue { get; private set; }

        public Player(string firstName, string lastName, int countryId, DateTime birthDate, int? clubId, int positionId)
            : base(firstName, lastName, countryId, birthDate)
        {
            ClubId = clubId;
            Position = Position.FromValue(positionId);
        }
    }
}
