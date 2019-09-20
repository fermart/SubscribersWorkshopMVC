using SubscribersApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubscribersApp.Infrastructure
{
    public class SubscriberContext: DbContext
    {
        public SubscriberContext(): base("SubscribersContext")
        {
            Database.SetInitializer<SubscriberContext>(new SubscriberDBInitializer());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new SubscriberConfigurations());
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Subscriber> Subscribers { get; set; }
    }
}
