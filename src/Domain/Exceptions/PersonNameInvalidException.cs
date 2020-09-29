using System;

namespace Domain.Exceptions
{
    public class PersonNameInvalidException : Exception
    {
        public PersonNameInvalidException()
            : base($"Invalid name. Both first name and last name are required.")
        {
        }
    }
}
