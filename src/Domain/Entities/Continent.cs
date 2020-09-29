using Domain.Common;
using System.Collections.Generic;

namespace Domain.Entities
{
    public class Continent : Entity<int>
    {
        public string Name { get; private set; }

        public IList<Country> Countries { get; private set; }
    }
}
