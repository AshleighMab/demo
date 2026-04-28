using System;
using Abp.Domain.Entities.Auditing;

namespace demo.demo.Domain.Ticketing
{
    public class TicketCategory : FullAuditedEntity<Guid>
    {
        public virtual string Name { get; set; }
        public virtual RefListTicketPriority? DefaultPriority { get; set; }
        public virtual SupportTeam DefaultTeam { get; set; }
    }
}
