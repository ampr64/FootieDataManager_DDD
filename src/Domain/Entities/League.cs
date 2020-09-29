using Domain.Common;
using System.Collections.Generic;

namespace Domain.Entities
{
    public class League : Entity<int>
    {
        public string Name { get; private set; }

        public int CountryId { get; private set; }

        public Country Country { get; private set; }

        public IList<Club> Clubs { get; private set; }
    }
}
