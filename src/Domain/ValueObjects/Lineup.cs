using Domain.Common;
using Domain.Constants;
using Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Domain.ValueObjects
{
    public class Lineup : ValueObject
    {
        public LineupPlayer[] Starters { get; private set; }

        public LineupPlayer[] Bench { get; private set; }

        public long CaptainId { get; private set; }

        public long ManagerId { get; private set; }

        private Lineup(
            LineupPlayer[] starters,
            LineupPlayer[] bench,
            long captainId,
            long managerId)
        {
            Starters = starters;
            Bench = bench;
            CaptainId = captainId;
            ManagerId = managerId;
        }

        public static Lineup For(
            IList<LineupPlayer> starters,
            IList<LineupPlayer> bench,
            long captainId,
            long managerId)
        {
            Check<LineupInvalidStartersNumberException>(starters, nameof(starters), starters.Count == LineupConstants.StartersCount);
            Check<LineupInvalidBenchNumberException>(bench, nameof(bench), bench.Count < LineupConstants.BenchMinimumCount || bench.Count > LineupConstants.BenchMaximumCount);

            return new Lineup(starters.ToArray(), bench.ToArray(), captainId, managerId);
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Starters;
            yield return Bench;
            yield return CaptainId;
        }

        private static void Check<TException>(IList<LineupPlayer> items, string paramName, bool condition)
            where TException : Exception
        {
            if (items is null)
                throw new ArgumentNullException(paramName);

            if (!condition)
                throw (TException)Activator.CreateInstance(typeof(TException), paramName);
        }
    }
}
