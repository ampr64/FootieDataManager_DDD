using Domain.Constants;
using System;

namespace Domain.Exceptions
{
    public class LineupInvalidBenchNumberException : Exception
    {
        public LineupInvalidBenchNumberException()
            : base ($"Invalid bench list. Number of bench players must be between {LineupConstants.BenchMinimumCount} and {LineupConstants.BenchMaximumCount}.")
        {
        }
    }
}
