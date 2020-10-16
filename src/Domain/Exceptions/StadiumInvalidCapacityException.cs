using System;

namespace Domain.Exceptions
{
    public class StadiumInvalidCapacityException : Exception
    {
        public StadiumInvalidCapacityException() :
            base("Stadium capacity must be greater than zero.")
        {
        }
    }
}
