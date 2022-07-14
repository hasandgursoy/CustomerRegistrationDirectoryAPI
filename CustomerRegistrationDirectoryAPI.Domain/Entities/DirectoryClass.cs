using CustomerRegistrationDirectoryAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerRegistrationDirectoryAPI.Domain.Entities
{
    public class DirectoryClass: BaseEntity
    {
        public ICollection<Customer> Customer { get; set; }


    }
}
