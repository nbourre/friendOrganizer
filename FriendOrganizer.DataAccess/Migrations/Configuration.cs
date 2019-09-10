namespace FriendOrganizer.DataAccess.Migrations
{
    using FriendOrganizer.Model;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<FriendOrganizerDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(FriendOrganizerDbContext context)
        {
            context.Friends.AddOrUpdate(
                f => f.FirstName,
                new Friend { FirstName = "Nicolas", LastName = "Bourré" },
                new Friend { FirstName = "Lyne", LastName = "Amyot" },
                new Friend { FirstName = "France", LastName = "Jean" },
                new Friend { FirstName = "Mathieu", LastName = "St-Yves" }
                );
        }
    }
}
