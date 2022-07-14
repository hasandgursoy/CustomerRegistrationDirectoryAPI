using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerRegistrationDirectoryAPI.Domain.Entities
{
    public class CustomerImageFile : File
    {
        public Guid CustomerId { get; set; }
        public Customer Customer { get; set; }

    }
}


