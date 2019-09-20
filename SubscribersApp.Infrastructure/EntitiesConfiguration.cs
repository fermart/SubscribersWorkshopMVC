using SubscribersApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubscribersApp.Infrastructure
{
    public class SubscriberConfigurations: EntityTypeConfiguration<Subscriber>
    {
        public SubscriberConfigurations()
        {
            this.Property(x => x.Name).IsRequired().HasMaxLength(120);
            this.Property(x => x.HomeAddress).HasMaxLength(255);
        }
    }

}
