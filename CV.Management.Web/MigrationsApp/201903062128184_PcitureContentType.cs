namespace CV.Management.Web.MigrationsApp
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PcitureContentType : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Profiles", "PictureContent", c => c.String());
            AddColumn("dbo.Profiles", "PictureType", c => c.String());
            DropColumn("dbo.Profiles", "Picture");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Profiles", "Picture", c => c.Binary());
            DropColumn("dbo.Profiles", "PictureType");
            DropColumn("dbo.Profiles", "PictureContent");
        }
    }
}
