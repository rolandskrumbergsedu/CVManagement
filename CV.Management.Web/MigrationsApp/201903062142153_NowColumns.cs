namespace CV.Management.Web.MigrationsApp
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NowColumns : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Educations", "Now", c => c.Boolean(nullable: false));
            AddColumn("dbo.Memberships", "Now", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Memberships", "Now");
            DropColumn("dbo.Educations", "Now");
        }
    }
}
