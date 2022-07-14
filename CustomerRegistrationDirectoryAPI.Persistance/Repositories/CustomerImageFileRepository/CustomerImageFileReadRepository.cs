using CustomerRegistrationDirectoryAPI.Application.Repositories.CustomerImageFileRepository;
using CustomerRegistrationDirectoryAPI.Domain.Entities;
using CustomerRegistrationDirectoryAPI.Persistance.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerRegistrationDirectoryAPI.Persistance.Repositories.CustomerImageFileRepository
{
    public class CustomerImageFileReadRepository : ReadRepository<CustomerImageFile>, ICustomerImageFileReadRepository
    {
        public CustomerImageFileReadRepository(CustomerRegistrationDirectoryAPIDbContext context) : base(context)
        {
        }
    }
}
