using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities.Auditing;
using Shesha.Domain.Attributes;

namespace demo.demo.Domain.Ticketing
{
    public class Ticket : FullAuditedEntity<Guid>
    {
        public virtual string Title { get; set; }
        public virtual RefListTicketCategory Category { get; set; }
        public virtual SupportTeam Team { get; set; }
        public virtual RefListTicketPriority Priority { get; set; }
        public virtual RefListTicketStatus Status { get; set; }

        [InverseProperty(nameof(TicketComment.Ticket) + "Id")]
        public virtual IList<TicketComment> Comments { get; set; } = new List<TicketComment>();

        [InverseProperty(nameof(TicketAttachment.Ticket) + "Id")]
        public virtual IList<TicketAttachment> Attachments { get; set; } = new List<TicketAttachment>();
    }
}
