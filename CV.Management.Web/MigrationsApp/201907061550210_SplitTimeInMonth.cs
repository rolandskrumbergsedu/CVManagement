namespace CV.Management.Web.MigrationsApp
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SplitTimeInMonth : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Positions", "FromTimeMonth", c => c.Int());
            AddColumn("dbo.Positions", "ToTimeMonth", c => c.Int());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Positions", "ToTimeMonth");
            DropColumn("dbo.Positions", "FromTimeMonth");
        }
    }
}
