namespace CV.Management.Web.MigrationsApp
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AdditionalCourses",
                c => new
                    {
                        AdditionalCourseId = c.Int(nullable: false, identity: true),
                        NumberOfDays = c.Int(),
                        Year = c.Int(),
                        CourseName = c.String(),
                        Trainer = c.String(),
                        Profile_ProfileId = c.Int(),
                    })
                .PrimaryKey(t => t.AdditionalCourseId)
                .ForeignKey("dbo.Profiles", t => t.Profile_ProfileId)
                .Index(t => t.Profile_ProfileId);
            
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
                        CurrentSalary = c.String(),
                        CurrentBonuses = c.String(),
                        SalaryRequest = c.String(),
                        BonusRequest = c.String(),
                        AdditionalBonuses = c.String(),
                        NoticePeriod = c.String(),
                        Comments = c.String(),
                    })
                .PrimaryKey(t => t.ProfileId);
            
            CreateTable(
                "dbo.Companies",
                c => new
                    {
                        CompanyId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        City = c.String(),
                        ParentCompanyName = c.String(),
                        MainProductions = c.String(),
                        Industry = c.Int(),
                        Turnover = c.Int(),
                        OtherIndustry = c.String(),
                        NumberOfEmployess = c.Int(),
                        Profile_ProfileId = c.Int(),
                    })
                .PrimaryKey(t => t.CompanyId)
                .ForeignKey("dbo.Profiles", t => t.Profile_ProfileId)
                .Index(t => t.Profile_ProfileId);
            
            CreateTable(
                "dbo.Positions",
                c => new
                    {
                        PositionId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        FromTime = c.Int(),
                        ToTime = c.Int(),
                        KeyTasks = c.String(),
                        ReportingTo = c.String(),
                        DirectSubordinates = c.String(),
                        Achievements = c.String(),
                        ReasonForLeaving = c.String(),
                        Company_CompanyId = c.Int(),
                    })
                .PrimaryKey(t => t.PositionId)
                .ForeignKey("dbo.Companies", t => t.Company_CompanyId)
                .Index(t => t.Company_CompanyId);
            
            CreateTable(
                "dbo.Educations",
                c => new
                    {
                        EducationId = c.Int(nullable: false, identity: true),
                        FromYear = c.Int(),
                        ToYear = c.Int(),
                        Institution = c.String(),
                        Degree = c.String(),
                        Profile_ProfileId = c.Int(),
                    })
                .PrimaryKey(t => t.EducationId)
                .ForeignKey("dbo.Profiles", t => t.Profile_ProfileId)
                .Index(t => t.Profile_ProfileId);
            
            CreateTable(
                "dbo.Languages",
                c => new
                    {
                        LanguageId = c.Int(nullable: false, identity: true),
                        LanguageName = c.Int(),
                        SpokenLevel = c.Int(),
                        WrittenLevel = c.Int(),
                        Profile_ProfileId = c.Int(),
                    })
                .PrimaryKey(t => t.LanguageId)
                .ForeignKey("dbo.Profiles", t => t.Profile_ProfileId)
                .Index(t => t.Profile_ProfileId);
            
            CreateTable(
                "dbo.Memberships",
                c => new
                    {
                        MembershipId = c.Int(nullable: false, identity: true),
                        FromTime = c.Int(),
                        ToTime = c.Int(),
                        Description = c.String(),
                        Profile_ProfileId = c.Int(),
                    })
                .PrimaryKey(t => t.MembershipId)
                .ForeignKey("dbo.Profiles", t => t.Profile_ProfileId)
                .Index(t => t.Profile_ProfileId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Memberships", "Profile_ProfileId", "dbo.Profiles");
            DropForeignKey("dbo.Languages", "Profile_ProfileId", "dbo.Profiles");
            DropForeignKey("dbo.Educations", "Profile_ProfileId", "dbo.Profiles");
            DropForeignKey("dbo.Companies", "Profile_ProfileId", "dbo.Profiles");
            DropForeignKey("dbo.Positions", "Company_CompanyId", "dbo.Companies");
            DropForeignKey("dbo.AdditionalCourses", "Profile_ProfileId", "dbo.Profiles");
            DropIndex("dbo.Memberships", new[] { "Profile_ProfileId" });
            DropIndex("dbo.Languages", new[] { "Profile_ProfileId" });
            DropIndex("dbo.Educations", new[] { "Profile_ProfileId" });
            DropIndex("dbo.Positions", new[] { "Company_CompanyId" });
            DropIndex("dbo.Companies", new[] { "Profile_ProfileId" });
            DropIndex("dbo.AdditionalCourses", new[] { "Profile_ProfileId" });
            DropTable("dbo.Memberships");
            DropTable("dbo.Languages");
            DropTable("dbo.Educations");
            DropTable("dbo.Positions");
            DropTable("dbo.Companies");
            DropTable("dbo.Profiles");
            DropTable("dbo.AdditionalCourses");
        }
    }
}
