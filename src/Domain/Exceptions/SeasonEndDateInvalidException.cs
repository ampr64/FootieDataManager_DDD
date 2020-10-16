using System;

namespace Domain.Exceptions
{
    public class SeasonEndDateInvalidException : Exception
    {
        public SeasonEndDateInvalidException(DateTime startDate, DateTime? endDate)
            : base($"End date {endDate} is invalid. It must be greater than Start Date ({startDate}).")
        {
        }
    }
}
