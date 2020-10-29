using System;

namespace Domain.Exceptions
{
    public class PersonNameNullOrEmptyException : Exception
    {
        public PersonNameNullOrEmptyException(string name, bool isFirst)
            : this(name, $"{(isFirst ? "First" : "Last")} name \"{name}\" is invalid.")
        {
        }

        public PersonNameNullOrEmptyException(string first, string last)
            : base($"First name \"{first}\" and last name \"{last}\" are invalid.")
        {
        }
    }
}
