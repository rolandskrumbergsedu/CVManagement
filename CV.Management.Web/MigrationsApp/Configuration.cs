namespace CV.Management.Web.MigrationsApp
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Infrastructure;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DbContexts.ProfileInformationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            MigrationsDirectory = @"MigrationsApp";
        }

        protected override void Seed(DbContexts.ProfileInformationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
