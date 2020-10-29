using Domain.Common;
using Domain.Entities.PlayerAggregate;
using Domain.Common.ValueObjects;
using System.Collections.Generic;
using Domain.Entities.ClubAggregate;

namespace Domain.Entities.MatchAggregate
{
    public class LineupPlayer : ValueObject
    {
        public long PlayerId { get; private set; }

        public PersonName Name { get; private set; }

        public int ClubId { get; private set; }

        public Club Club { get; private set; }

        public SquadNumber SquadNumber { get; private set; }

        private LineupPlayer() { }

        public LineupPlayer(long playerId, PersonName name, int clubId, SquadNumber squadNumber)
        {
            PlayerId = playerId;
            Name = name;
            ClubId = clubId;
            SquadNumber = squadNumber;
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return PlayerId;
            yield return ClubId;
            yield return SquadNumber;
        }

        public override string ToString() => $"{Name} ({SquadNumber}) - {Club.Name}";
    }
}
