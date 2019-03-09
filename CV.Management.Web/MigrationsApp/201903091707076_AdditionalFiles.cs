namespace CV.Management.Web.MigrationsApp
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AdditionalFiles : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AdditionalFiles",
                c => new
                    {
                        AdditionalFileId = c.Int(nullable: false, identity: true),
                        FileContent = c.String(),
                        FileType = c.String(),
                        FileName = c.String(),
                        Profile_ProfileId = c.Int(),
                    })
                .PrimaryKey(t => t.AdditionalFileId)
                .ForeignKey("dbo.Profiles", t => t.Profile_ProfileId)
                .Index(t => t.Profile_ProfileId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AdditionalFiles", "Profile_ProfileId", "dbo.Profiles");
            DropIndex("dbo.AdditionalFiles", new[] { "Profile_ProfileId" });
            DropTable("dbo.AdditionalFiles");
        }
    }
}
