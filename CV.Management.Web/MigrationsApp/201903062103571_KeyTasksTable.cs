namespace CV.Management.Web.MigrationsApp
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class KeyTasksTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.KeyTasks",
                c => new
                    {
                        KeyTaskId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Position_PositionId = c.Int(),
                    })
                .PrimaryKey(t => t.KeyTaskId)
                .ForeignKey("dbo.Positions", t => t.Position_PositionId)
                .Index(t => t.Position_PositionId);
            
            DropColumn("dbo.Positions", "KeyTasks");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Positions", "KeyTasks", c => c.String());
            DropForeignKey("dbo.KeyTasks", "Position_PositionId", "dbo.Positions");
            DropIndex("dbo.KeyTasks", new[] { "Position_PositionId" });
            DropTable("dbo.KeyTasks");
        }
    }
}
