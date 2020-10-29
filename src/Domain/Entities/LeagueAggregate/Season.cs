using Domain.Common;
using Domain.Entities.ClubAggregate;
using Domain.Exceptions;
using System;
using System.Collections.Generic;

namespace Domain.Entities.LeagueAggregate
{
    public class Season : Entity<long>
    {
        public int LeagueId { get; private set; }

        public string DisplayName
        { 
            get
            {
                if (!EndDate.HasValue || EndDate.Value.Year == StartDate.Year)
                    return StartDate.Year.ToString();

                return $"{StartDate.Year} - {EndDate.Value.Year}";
            }
        }

        public DateTime StartDate { get; private set; }

        public DateTime? EndDate { get; private set; }

        public IList<Club> PromotedClubs { get; private set; }

        public IList<Club> RelegatedClubs { get; private set; }

        public Season(int leagueId, DateTime startDate, DateTime? endDate = null)
        {
            LeagueId = leagueId;
            StartDate = startDate;
            EndDate = endDate;
        }

        public void SetEndDate(DateTime? endDate)
        {
            if (StartDate >= endDate)
                throw new SeasonEndDateInvalidException(StartDate, endDate);

            EndDate = endDate;
        }

        public override string ToString() => DisplayName;
    }
}
