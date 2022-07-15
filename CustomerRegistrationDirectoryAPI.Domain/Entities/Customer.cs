using CustomerRegistrationDirectoryAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerRegistrationDirectoryAPI.Domain.Entities
{
    public class Customer : BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string City { get; set; }
        public ICollection<CustomerImageFile> CustomerImageFiles { get; set; }
        public ICollection<Trade> Trades { get; set; }
        public Guid DirectoryId { get; set; }
        public DirectoryClass Directory { get; set; }

    }
}
