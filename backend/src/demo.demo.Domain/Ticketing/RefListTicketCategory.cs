using System.ComponentModel;
using Shesha.Domain.Attributes;

namespace demo.demo.Domain.Ticketing
{
    [ReferenceList("demo.demo", "TicketCategory")]
    public enum RefListTicketCategory : long
    {
        [Description("Access")]
        Access = 1,
        [Description("Billing")]
        Billing = 2,
        [Description("Technical")]
        Technical = 3
    }
}
