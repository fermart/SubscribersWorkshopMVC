namespace SubscribersApp.Infrastructure.Migrations
{
    using SubscribersApp.Core.Entities;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SubscribersApp.Infrastructure.SubscriberContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(SubscribersApp.Infrastructure.SubscriberContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            context.Subscribers.AddOrUpdate(new Subscriber { Name = "Axel Saredo", HomeAddress = "Peru 375" });

        }
    }
}
