using CV.Management.Web.Models;
using CV.Management.Web.Models.Database;
using System.Data.Entity;

namespace CV.Management.Web.DbContexts
{
    public class ProfileInformationDbContext : DbContext
    {
        public ProfileInformationDbContext()
            : base("DefaultConnection")
        {
           Database.SetInitializer(new MigrateDatabaseToLatestVersion<ProfileInformationDbContext, MigrationsApp.Configuration>("DefaultConnection"));
        }

        public DbSet<Profile> Profiles { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Membership> Memberships { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<AdditionalCourse> AdditionalCourses { get; set; }
        public DbSet<AdditionalFile> AdditionalFiles { get; set; }
    }
}