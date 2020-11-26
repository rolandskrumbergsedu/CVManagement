namespace CV.Management.Web.MigrationsApp
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OtherLanguage : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Languages", "OtherLanguage", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Languages", "OtherLanguage");
        }
    }
}
