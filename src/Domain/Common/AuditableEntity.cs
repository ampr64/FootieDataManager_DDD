using System;

namespace Domain.Common
{
    public abstract class AuditableEntity<TId> : Entity<TId>
        where TId : IEquatable<TId>
    {
        public DateTime CreatedOn { get; set; }

        public string CreatedBy { get; set; }

        public DateTime? LastModifiedOn { get; set; }

        public string LastModifiedBy { get; set; }
    }
}
