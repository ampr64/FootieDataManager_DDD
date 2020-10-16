using Domain.Common;
using Domain.Exceptions;
using System;

namespace Domain.Entities
{
    public class Stadium : Entity<int>, IAggregateRoot
    {
        public string Name { get; private set; }

        public int ClubId { get; private set; }

        public Club Club { get; private set; }

        public int Capacity { get; private set; }

        public int BuiltIn { get; private set; }

        public Stadium(string name, int clubId, int capacity, int builtIn)
        {
            Name = name;
            ClubId = clubId;
            Capacity = capacity;
            BuiltIn = builtIn;
        }

        public void UpdateDetails(int capacity, int builtIn)
        {
            BuiltIn = builtIn;
            SetCapacity(capacity);
        }

        public void SetCapacity(int capacity)
        {
            if (capacity <= 0)
                throw new StadiumInvalidCapacityException();

            Capacity = capacity;
        }

        public void SetName(string name)
        {
            if (string.IsNullOrEmpty(name))
                throw new ArgumentException($"{nameof(name)} cannot be null or empty.");

            Name = name;
        }
    }
}
