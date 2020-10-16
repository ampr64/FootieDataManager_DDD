using System;

namespace Domain.Exceptions
{
    public class SquadNumberInvalidException : Exception
    {
        public SquadNumberInvalidException(int squadNumber)
            : base($"\"{squadNumber}\" is not a valid squad number. The range of valid values goes from 1 to 99.")
        {
        }
    }
}
