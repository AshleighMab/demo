using System.ComponentModel;
using Shesha.Domain.Attributes;

namespace demo.demo.Domain.Ticketing
{
    [ReferenceList("demo.demo", "TicketStatus")]
    public enum RefListTicketStatus : long
    {
        [Description("New")]
        New = 1,
        [Description("Assigned")]
        Assigned = 2,
        [Description("In Progress")]
        InProgress = 3,
        [Description("Resolved")]
        Resolved = 4,
        [Description("Closed")]
        Closed = 5
    }
}
