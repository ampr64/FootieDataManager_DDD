using Domain.Common;
using Domain.Enumerations;

namespace Domain.Entities
{
    public class Goal : Entity<long>
    {
        public long MatchId { get; private set; }

        public Player ScoredBy { get; private set; }

        public Player AssistedBy { get; private set; }

        public Club ClubFor { get; private set; }

        public Club ClubAgainst { get; private set; }

        public int Minute { get; private set; }

        public GoalType Type { get; private set; }

        public override string ToString() =>
            $"{ScoredBy} - {Minute}\" {(Type == GoalType.Penalty ? "(P)" : string.Empty)}";
    }
}
