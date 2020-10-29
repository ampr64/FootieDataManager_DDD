using Domain.Common;
using Domain.Entities.ClubAggregate;
using Domain.Entities.LeagueAggregate;
using Domain.Entities.MatchAggregate;
using Domain.Entities.PlayerAggregate;
using Domain.Enums;
using System.Collections.Generic;

namespace Domain.Common.ValueObjects
{
    public class Booking : ValueObject
    {
        public long MatchId { get; private set; }

        public Match Match { get; private set; }

        public int Minute { get; private set; }

        public long PlayerId { get; private set; }

        public Player Player { get; private set; }

        public int ClubId { get; private set; }

        public Club Club { get; private set; }

        public Card Card { get; private set; }

        public override string ToString() =>
            $"{Player?.Name}: {Card} ({Minute}\")";

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return MatchId;
            yield return PlayerId;
            yield return ClubId;
            yield return Card;
            yield return Minute;
        }
    }
}
