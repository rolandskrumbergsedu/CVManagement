namespace CV.Management.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Profiles",
                c => new
                    {
                        ProfileId = c.Int(nullable: false, identity: true),
                        Username = c.String(),
                        Picture = c.Binary(),
                        FullName = c.String(),
                        LinkedInLink = c.String(),
                        Address = c.String(),
                        Email = c.String(),
                        Phone = c.String(),
                        Skype = c.String(),
                        Project = c.String(),
                    })
                .PrimaryKey(t => t.ProfileId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Profiles");
        }
    }
}
