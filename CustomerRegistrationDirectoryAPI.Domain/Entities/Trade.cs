using CustomerRegistrationDirectoryAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerRegistrationDirectoryAPI.Domain.Entities
{
    public class Trade : BaseEntity
    {
        public  Guid CustomerId { get; set; }
        public Customer Customer { get; set; }
        public string Description { get; set; }
        public decimal TradeVolume { get; set; }
    }
}
