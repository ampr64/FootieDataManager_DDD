using Domain.Constants;
using System;

namespace Domain.Exceptions
{
    public class PersonNameContainsInvalidCharactersException : Exception
    {
        private static readonly string _allowedSpecials =
            string.Join(',', $"\"{PersonNameConstants.AllowedSpecialCharacters}\"");

        private static readonly string Description =
            $"Names may only contain letters and special characters such as {_allowedSpecials}";

    public PersonNameContainsInvalidCharactersException(string name, bool isFirst)
            : this(name, $"{(isFirst ? "First" : "Last")} name \"{name}\" is invalid. {Description}")
        {
        }

        public PersonNameContainsInvalidCharactersException(string first, string last)
            : base($"First name \"{first}\" and last name \"{last}\" are invalid. {Description}")
        {
        }
    }
}
