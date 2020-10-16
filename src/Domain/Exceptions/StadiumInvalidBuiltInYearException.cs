using Domain.Constants;
using System;

namespace Domain.Exceptions
{
    public class StadiumInvalidBuiltInYearException : Exception
    {
        public StadiumInvalidBuiltInYearException(int year)
            : base($"{year} is not a valid built year. Minimum year accepted is {StadiumConstants.MinimumBuiltInYear}.")
        {
        }
    }
}
