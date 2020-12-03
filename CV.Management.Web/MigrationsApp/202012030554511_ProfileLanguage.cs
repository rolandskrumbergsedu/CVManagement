namespace CV.Management.Web.MigrationsApp
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ProfileLanguage : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Profiles", "Language", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Profiles", "Language");
        }
    }
}
