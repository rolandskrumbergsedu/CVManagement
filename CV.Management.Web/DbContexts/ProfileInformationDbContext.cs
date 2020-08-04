using CV.Management.Web.Helpers;
using CV.Management.Web.Models.Database;
using System.Data.Entity;
using System.Data.Entity.SqlServer;

namespace CV.Management.Web.DbContexts
{
    [DbConfigurationType(typeof(DatabaseConfiguration))]
    public class ProfileInformationDbContext : DbContext
    {
        public ProfileInformationDbContext()
            : base(GetConnectionString())
        {
           Database.SetInitializer(new MigrateDatabaseToLatestVersion<ProfileInformationDbContext, MigrationsApp.Configuration>(true));

#if DEBUG
            Database.Log = s => { };
#endif
        }

        public DbSet<Profile> Profiles { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Membership> Memberships { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<AdditionalCourse> AdditionalCourses { get; set; }
        public DbSet<AdditionalFile> AdditionalFiles { get; set; }
        public DbSet<AuditLog> AuditLogs { get; set; }

        private static string GetConnectionString()
        {
            return ConfigurationHelper.Database;
        }
    }

    public class DatabaseConfiguration : DbConfiguration
    {
        public DatabaseConfiguration()
        {
            SetExecutionStrategy("System.Data.SqlClient", () => new SqlAzureExecutionStrategy());
        }
    }
}