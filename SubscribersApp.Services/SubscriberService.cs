using SubscribersApp.Core.Contracts.Base;
using SubscribersApp.Core.Contracts.Services;
using SubscribersApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubscribersApp.Services
{
    public class SubscriberService: EntityService<Subscriber>, ISubscriberService
    {
        private readonly IRepository<Subscriber> _subscriberRepository;

        public SubscriberService(IRepository<Subscriber> subscriberRepository) : base(subscriberRepository)
        {
            _subscriberRepository = subscriberRepository;
        }
    }
}
