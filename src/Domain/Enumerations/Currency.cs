using Domain.Common;

namespace Domain.Enumerations
{
    public class Currency : Enumeration<Currency>
    {
        public Currency ARS = new Currency(1, nameof(ARS));
        public Currency EUR = new Currency(2, nameof(EUR));
        public Currency GBP = new Currency(3, nameof(GBP));
        public Currency USD = new Currency(4, nameof(USD));

        private Currency(int value, string name)
            : base(value, name)
        {
        }
    }
}
