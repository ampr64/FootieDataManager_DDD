using Domain.Common;
using Domain.Enums;
using Domain.Exceptions;
using System;

namespace Domain.ValueObjects
{
    public class PlayerPosition : ValueObject
    {
        public string Name { get; private set; }

        private PlayerPosition(string positionName) => Name = positionName;

        public static PlayerPosition For(string positionName)
        {
            if (Enum.TryParse<PlayerPositionEnum>(positionName, out var _))
                throw new PlayerPositionInvalidException(positionName);

            return new PlayerPosition(positionName);
        }
    }
}
