using System.ComponentModel;
using Shesha.Domain.Attributes;

namespace demo.demo.Domain.Ticketing
{
    [ReferenceList("demo.demo", "TicketPriority")]
    public enum RefListTicketPriority : long
    {
        [Description("Low")]
        Low = 1,
        [Description("Medium")]
        Medium = 2,
        [Description("High")]
        High = 3,
        [Description("Critical")]
        Critical = 4
    }
}
