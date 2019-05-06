namespace CV.Management.Web.MigrationsApp
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PhoneCode : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Profiles", "PhoneCode", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Profiles", "PhoneCode");
        }
    }
}
