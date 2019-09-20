using SubscribersApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubscribersApp.Infrastructure
{
    public class SubscriberDBInitializer: DropCreateDatabaseIfModelChanges<SubscriberContext>
    {
        protected override void Seed(SubscriberContext context)
        {
            context.Subscribers.AddOrUpdate(new Subscriber { Name = "Axel Saredo", HomeAddress = "Peru 375" });

            base.Seed(context);
        }

    }
}
