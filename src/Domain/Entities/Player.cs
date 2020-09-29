using Domain.Common;
using Domain.ValueObjects;
using System;

namespace Domain.Entities
{
    public class Player : Person, IAggregateRoot
    {
        public int ClubId { get; private set; }

        public Club Club { get; private set; }

        public PlayerPosition Position { get; private set; }

        public Player(string firstName, string lastName, int countryId, DateTime birthDate, int clubId, PlayerPosition position)
            : base(firstName, lastName, countryId, birthDate)
        {
            ClubId = clubId;
            Position = position;
        }
    }
}
