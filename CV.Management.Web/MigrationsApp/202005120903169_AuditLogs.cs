namespace CV.Management.Web.MigrationsApp
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AuditLogs : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AuditLogs",
                c => new
                    {
                        AuditLogId = c.Int(nullable: false, identity: true),
                        AuditEvent = c.String(),
                        Username = c.String(),
                        EventTime = c.DateTime(nullable: false),
                        UserAffected = c.String(),
                        UserAffectedId = c.String(),
                    })
                .PrimaryKey(t => t.AuditLogId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.AuditLogs");
        }
    }
}
