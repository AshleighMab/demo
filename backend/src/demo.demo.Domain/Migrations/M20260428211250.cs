using FluentMigrator;
using Shesha.FluentMigrator;

namespace demo.demo.Domain.Migrations
{
    /// <summary>
    /// Creates the Ticketing system tables: SupportTeams, TicketCategories, Tickets, TicketComments, TicketAttachments
    /// </summary>
    [Migration(20260428211250)]
    public class M20260428211250 : OneWayMigration
    {
        public override void Up()
        {
            Create.Table("demo_SupportTeams")
                .WithIdAsGuid()
                .WithFullAuditColumns()
                .WithColumn("Name").AsString().Nullable();

            Alter.Table("demo_SupportTeams")
                .AddForeignKeyColumn("TeamLeadId", "Core_Persons").Nullable();

            Create.Table("demo_TicketCategories")
                .WithIdAsGuid()
                .WithFullAuditColumns()
                .WithColumn("Name").AsString().Nullable()
                .WithColumn("DefaultPriorityLkp").AsInt64().Nullable();

            Alter.Table("demo_TicketCategories")
                .AddForeignKeyColumn("DefaultTeamId", "demo_SupportTeams").Nullable();
          
            Create.Table("demo_Tickets")
                .WithIdAsGuid()
                .WithFullAuditColumns()
                .WithColumn("Title").AsString().Nullable()
                .WithColumn("CategoryLkp").AsInt64().NotNullable()
                .WithColumn("PriorityLkp").AsInt64().NotNullable()
                .WithColumn("StatusLkp").AsInt64().NotNullable();

            Alter.Table("demo_Tickets")
                .AddForeignKeyColumn("TeamId", "demo_SupportTeams").Nullable();

            Create.Table("demo_TicketComments")
                .WithIdAsGuid()
                .WithFullAuditColumns()
                .WithColumn("Comment").AsString(5000).Nullable();

            Alter.Table("demo_TicketComments")
                .AddForeignKeyColumn("TicketId", "demo_Tickets").Nullable()
                .AddForeignKeyColumn("AuthorId", "Core_Persons").Nullable();

            Create.Table("demo_TicketAttachments")
                .WithIdAsGuid()
                .WithFullAuditColumns();

            Alter.Table("demo_TicketAttachments")
                .AddForeignKeyColumn("TicketId", "demo_Tickets").Nullable()
                .AddForeignKeyColumn("UploadedById", "Core_Persons").Nullable();

            Alter.Table("demo_TicketAttachments")
                .AddColumn("FileId").AsGuid().Nullable()
                .ForeignKey("FK_demo_TicketAttachments_FileId", "frwk", "stored_files", "Id");
        }
    }
}
