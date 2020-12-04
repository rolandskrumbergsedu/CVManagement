namespace CV.Management.Web.MigrationsApp
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AchievementsSeparate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Achievements",
                c => new
                    {
                        AchievementId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Position_PositionId = c.Int(),
                    })
                .PrimaryKey(t => t.AchievementId)
                .ForeignKey("dbo.Positions", t => t.Position_PositionId)
                .Index(t => t.Position_PositionId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Achievements", "Position_PositionId", "dbo.Positions");
            DropIndex("dbo.Achievements", new[] { "Position_PositionId" });
            DropTable("dbo.Achievements");
        }
    }
}
