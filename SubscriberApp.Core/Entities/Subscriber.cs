using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubscribersApp.Core.Entities
{
    public class Subscriber:Entity
    {
        [Required]
        public string Name { get; set; }
        public string HomeAddress { get; set; }
    }
}
