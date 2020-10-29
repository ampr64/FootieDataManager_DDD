using Domain.Common;
using Domain.Exceptions;

namespace Domain.Rules
{
    public class PersonNameMustHaveFirstAndLastRule : IBusinessRule
    {
        private readonly string _first;
        private readonly string _last;

        public PersonNameMustHaveFirstAndLastRule(string first, string last)
        {
            _first = first;
            _last = last;
        }

        public void Enforce()
        {
            if (string.IsNullOrWhiteSpace(_first))
            {
                if (string.IsNullOrWhiteSpace(_last))
                    throw new PersonNameNullOrEmptyException(_first, _last);

                throw new PersonNameNullOrEmptyException(_first, true);
            }

            if (string.IsNullOrWhiteSpace(_last))
                throw new PersonNameNullOrEmptyException(_last, false);
        }
    }
}
