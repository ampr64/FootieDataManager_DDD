using Domain.Common;
using Domain.Common.ValueObjects;
using Domain.Entities.ClubAggregate;
using System;
using System.Collections.Generic;

namespace Domain.Entities.MatchAggregate
{
    public class Match : Entity<long>, IAggregateRoot
    {
        public int LeagueId { get; private set; }

        public long SeasonId { get; private set; }

        public int HomeId { get; private set; }

        public Club Home { get; private set; }

        public int AwayId { get; private set; }

        public Club Away { get; private set; }

        public Lineup HomeLineup { get; private set; }

        public Lineup AwayLineup { get; private set; }

        public IList<Goal> HomeGoals { get; private set; }

        public IList<Goal> AwayGoals { get; private set; }

        public Manager HomeManager { get; private set; }

        public Manager AwayManager { get; private set; }

        public int Attendance { get; private set; }

        public DateTime Date { get; private set; }

        public int StadiumId { get; private set; }

        public Stadium Stadium { get; private set; }

        public long RefereeId { get; private set; }

        public Referee Referee { get; private set; }
    }
}
