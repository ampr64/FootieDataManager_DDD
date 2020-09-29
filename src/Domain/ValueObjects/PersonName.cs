using Domain.Common;
using Domain.Exceptions;

namespace Domain.ValueObjects
{
    public class PersonName : ValueObject
    {
        public string First { get; private set; }

        public string Last { get; private set; }

        public string FullName => $"{First} {Last}";

        private PersonName(string first, string last)
        {
            First = first;
            Last = last;
        }

        public static PersonName Of(string first, string last)
        {
            if (string.IsNullOrWhiteSpace(first) || string.IsNullOrWhiteSpace(last))
                throw new PersonNameInvalidException();

            return new PersonName(first, last); 
        }
    }
}
