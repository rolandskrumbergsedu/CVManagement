namespace CV.Management.Web.MigrationsApp
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SkypeToOther : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Profiles", "OtherInformation", c => c.String());
            DropColumn("dbo.Profiles", "Skype");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Profiles", "Skype", c => c.String());
            DropColumn("dbo.Profiles", "OtherInformation");
        }
    }
}
