using System.Collections.Generic;

namespace Domain.Constants
{
    public static class PersonNameConstants
    {
        public static readonly IReadOnlyCollection<char> AllowedSpecialCharacters = new[]
        {
            ' ', '-', '\''
        };

        public static readonly int MaximumLength = 50;
    }
}
