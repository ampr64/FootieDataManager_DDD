using Domain.Constants;
using System;

namespace Domain.Exceptions
{
    public class SquadNumberInvalidException : Exception
    {
        public SquadNumberInvalidException(int squadNumber)
            : base($"\"{squadNumber}\" is not a valid squad number." +
                  $"Number must be between {SquadNumberConstants.Min} and {SquadNumberConstants.Max}.")
        {
        }
    }
}
