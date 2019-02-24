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
        }

        public DbSet<Profile> Profiles { get; set; }

    }
}