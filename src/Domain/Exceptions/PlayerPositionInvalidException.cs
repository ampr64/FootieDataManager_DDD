using System;

namespace Domain.Exceptions
{
    public class PlayerPositionInvalidException : Exception
    {
        public PlayerPositionInvalidException(string positionName)
            : base($"Position \"{positionName}\" is not a valid player position.")
        {
        }
    }
}
