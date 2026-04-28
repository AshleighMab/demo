using System;
using System.ComponentModel.DataAnnotations;
using Abp.Domain.Entities.Auditing;
using Shesha.Domain;

namespace demo.demo.Domain.Ticketing
{
    public class TicketComment : FullAuditedEntity<Guid>
    {
        [Required]
        public virtual Ticket Ticket { get; set; }

        [StringLength(5000)]
        public virtual string Comment { get; set; }

        public virtual Person Author { get; set; }
    }
}
