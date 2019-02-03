using CV.Management.Web.Models;
using System.Data.Entity;

namespace CV.Management.Web.DbContexts
{
    public class ProfileInformationDbContext : DbContext
    {
        public ProfileInformationDbContext()
            : base("DefaultConnection")
        {
        }

        public DbSet<ProfilePicture> ProfilePictures { get; set; }
    }
}