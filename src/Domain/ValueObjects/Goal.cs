using Domain.Entities.ClubAggregate;
using Domain.Entities.MatchAggregate;
using Domain.Enumerations;
using System.Collections.Generic;

namespace Domain.Common.ValueObjects
{
    public class Goal : ValueObject
    {
        public long MatchId { get; private set; }

        public LineupPlayer ScoredBy { get; private set; }

        public LineupPlayer AssistedBy { get; private set; }

        public Club For { get; private set; }

        public Club Against { get; private set; }

        public int Minute { get; private set; }

        public GoalType Type { get; private set; }

        public bool IsOwnGoal => ScoredBy.Club == Against;

        public override string ToString() =>
            $"{ScoredBy} - {Minute}\"{(Type == GoalType.Penalty ? " (P)" : string.Empty)}";

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return MatchId;
            yield return ScoredBy;
            yield return AssistedBy;
            yield return Against;
            yield return Minute;
            yield return Type;
        }
    }
}
