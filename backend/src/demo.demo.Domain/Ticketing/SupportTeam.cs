using System;
using Abp.Domain.Entities.Auditing;
using Shesha.Domain;

namespace demo.demo.Domain.Ticketing
{
    public class SupportTeam : FullAuditedEntity<Guid>
    {
        public virtual string Name { get; set; }
        public virtual Person TeamLead { get; set; }
    }
}
