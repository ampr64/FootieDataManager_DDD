using Domain.Common;
using Domain.Entities.LeagueAggregate;
using System;
using System.Collections.Generic;

namespace Domain.Entities.LeagueAggregate
{
    public class Match : Entity<long>
    {
        public int LeagueId { get; private set; }

        public League League { get; private set; }

        public int HomeId { get; private set; }

        public Club Home { get; private set; }

        public int AwayId { get; private set; }

        public Club Away { get; private set; }

        public IList<Player> HomeLineup { get; private set; }

        public IList<Player> AwayLineup { get; private set; }

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
