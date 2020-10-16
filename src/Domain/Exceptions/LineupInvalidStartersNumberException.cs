using Domain.Constants;
using System;

namespace Domain.Exceptions
{
    public class LineupInvalidStartersNumberException : Exception
    {
        public LineupInvalidStartersNumberException()
            : base ($"Invalid starter list. Number of starters must be {LineupConstants.StartersCount}")
        {
        }
    }
}
