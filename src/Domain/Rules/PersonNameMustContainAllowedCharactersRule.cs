using Domain.Common;
using Domain.Constants;
using Domain.Exceptions;
using System.Linq;

namespace Domain.Rules
{
    public class PersonNameMustContainAllowedCharactersRule : IBusinessRule
    {
        private readonly string _first;
        private readonly string _last;

        public PersonNameMustContainAllowedCharactersRule(string first, string last)
        {
            _first = first;
            _last = last;
        }

        public void Enforce()
        {
            if (ContainsDisallowedCharacters(_first))
            {
                if (ContainsDisallowedCharacters(_last))
                    throw new PersonNameContainsInvalidCharactersException(_first, _last);

                throw new PersonNameContainsInvalidCharactersException(_first, true);
            }

            if (ContainsDisallowedCharacters(_last))
                throw new PersonNameContainsInvalidCharactersException(_last, false);
        }

        private bool ContainsDisallowedCharacters(string name) =>
            name.Any(_ => !char.IsLetter(_)
            || PersonNameConstants.AllowedSpecialCharacters.Contains(_));
    }
}
