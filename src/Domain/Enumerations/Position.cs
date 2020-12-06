﻿using Domain.Common;

namespace Domain.Enumerations
{
    public class Position : Enumeration<Position>
    {
        public static Position Goalkeeper = new Position(1, nameof(Goalkeeper));
        public static Position Defender = new Position(2, nameof(Defender));
        public static Position Midfielder = new Position(3, nameof(Midfielder));
        public static Position Forward = new Position(4, nameof(Forward));

        private Position(int value, string name)
            : base(value, name)
        {
        }
    }
}