namespace CV.Management.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TermsAndConditions : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "HasAcceptedTermsAndConditions", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "HasAcceptedTermsAndConditions");
        }
    }
}
