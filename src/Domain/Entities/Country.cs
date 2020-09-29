using Domain.Common;
using System.Collections.Generic;

namespace Domain.Entities
{
    public class Country : Entity<int>
    {
        public string Name { get; private set; }

        public int ContinentId { get; private set; }

        public Continent Continent { get; private set; }

        public string FlagUrl { get; private set; }

        public IList<League> Leagues { get; private set; }
    }
}
