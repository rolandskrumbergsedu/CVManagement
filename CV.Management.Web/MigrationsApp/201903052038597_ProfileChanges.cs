namespace CV.Management.Web.MigrationsApp
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ProfileChanges : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Positions", "Now", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Companies", "Turnover", c => c.String());
            AlterColumn("dbo.Companies", "NumberOfEmployess", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Companies", "NumberOfEmployess", c => c.Int());
            AlterColumn("dbo.Companies", "Turnover", c => c.Int());
            DropColumn("dbo.Positions", "Now");
        }
    }
}
