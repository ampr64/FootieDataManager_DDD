using Domain.Common;

namespace Domain.Entities.PlayerAggregate
{
    public class Foot : Enumeration<Foot>
    {
        public Foot Right = new Foot(1, nameof(Right));
        public Foot Left = new Foot(2, nameof(Left));

        private Foot(int value, string name)
            : base(value, name)
        {
        }
    }
}
