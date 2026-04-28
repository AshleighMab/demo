using System;
using System.ComponentModel.DataAnnotations;
using Abp.Domain.Entities.Auditing;
using Shesha.Domain;
using Shesha.Domain.Attributes;

namespace demo.demo.Domain.Ticketing
{
    public class TicketAttachment : FullAuditedEntity<Guid>
    {
        [Required]
        public virtual Ticket Ticket { get; set; }

        [StoredFile]
        public virtual StoredFile File { get; set; }

        public virtual Person UploadedBy { get; set; }
    }
}
