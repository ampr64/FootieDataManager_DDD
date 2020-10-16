using Domain.Common;
using Domain.Entities;
using System.Collections.Generic;

namespace Domain.ValueObjects
{
    public class LineupPlayer : ValueObject
    {
        public string Name { get; private set; }

        public long PlayerId { get; private set; }

        public Player Player { get; private set; }

        public int ClubId { get; private set; }

        public Club Club { get; private set; }

        public SquadNumber SquadNumber { get; private set; }

        private LineupPlayer() { }

        public LineupPlayer(long playerId, int clubId, SquadNumber squadNumber)
        {
            PlayerId = playerId;
            ClubId = clubId;
            SquadNumber = squadNumber;
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return PlayerId;
            yield return ClubId;
        }

        public override string ToString() => $"{Player.Name} ({SquadNumber}) - {Club.Name}";
    }
}
