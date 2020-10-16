using Domain.Common;

namespace Domain.Enumerations
{
    public class Card : Enumeration<Card>
    {
        public Card Yellow = new Card(1, nameof(Yellow));
        public Card Red = new Card(2, nameof(Red));

        public Card(int value, string name)
            : base(value, name)
        {
        }
    }
}
