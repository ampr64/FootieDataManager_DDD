using Domain.Common;
using System;

namespace Domain.Entities
{
    public class Stadium : Entity<int>
    {
        public string Name { get; private set; }

        public int ClubId { get; private set; }

        public Club Club { get; private set; }

        public int Capacity { get; private set; }

        public void SetCapacity(int capacity)
        {
            if (capacity <= 0)
                throw new ArgumentException($"{nameof(capacity)} must be greater than zero.");

            Capacity = capacity;
        }
    }
}
