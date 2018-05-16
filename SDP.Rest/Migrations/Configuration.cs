namespace SDP.Rest.Migrations
{
    using SDP.Rest.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SDP.Rest.Models.SDPRestContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(SDP.Rest.Models.SDPRestContext context)
        {
            // This method will be called after migrating to the latest version.
            // You can use the DbSet<T>.AddOrUpdate() helper extension method
            // to avoid creating duplicate seed data. E.g.
            context.Students.AddOrUpdate(
            new Student { Id = 0, FirstName = "Roch", Lastname = "Kowalski" },
            new Student { Id = 1, FirstName = "Anna", Lastname = "Nowak" },
            new Student { Id = 2, FirstName = "Martyna", Lastname = "Nowaczyk" },
            new Student { Id = 3, FirstName = "Bazyli", Lastname = "Zapolski" },
            new Student { Id = 3, FirstName = "Piotr", Lastname = "Wolski" },
            new Student { Id = 4, FirstName = "John", Lastname = "Snow" },
            new Student { Id = 5, FirstName = "Sam", Lastname = "Witwicky" },
            new Student { Id = 6, FirstName = "Tony", Lastname = "Stark" },
            new Student { Id = 7, FirstName = "Eddard", Lastname = "Stark" },
            new Student { Id = 8, FirstName = "Arya", Lastname = "Stark" }
            );
        }
    }
}
