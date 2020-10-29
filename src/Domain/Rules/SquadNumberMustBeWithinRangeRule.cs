using Domain.Common;
using Domain.Constants;
using Domain.Exceptions;

namespace Domain.Rules
{
    public class SquadNumberMustBeWithinRangeRule : IBusinessRule
    {
        private readonly int _number;

        public SquadNumberMustBeWithinRangeRule(int number)
        {
            _number = number;
        }

        public void Enforce()
        {
            if (_number < SquadNumberConstants.Min || _number > SquadNumberConstants.Max)
                throw new SquadNumberInvalidException(_number);
        }
    }
}
