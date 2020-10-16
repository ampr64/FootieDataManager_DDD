using Domain.Common;
using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public class Chairman : Person
    {
        public IList<Club> Clubs { get; private set; }

        public Chairman(string firstName, string lastName, int countryId, DateTime birthDate)
            : base(firstName, lastName, countryId, birthDate)
        {
        }
    }
}
