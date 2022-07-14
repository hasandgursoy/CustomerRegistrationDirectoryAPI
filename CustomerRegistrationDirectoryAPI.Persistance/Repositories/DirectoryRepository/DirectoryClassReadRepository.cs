using CustomerRegistrationDirectoryAPI.Application.Repositories.DirectoryRepository;
using CustomerRegistrationDirectoryAPI.Domain.Entities;
using CustomerRegistrationDirectoryAPI.Persistance.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerRegistrationDirectoryAPI.Persistance.Repositories.DirectoryRepository
{
    public class DirectoryClassReadRepository : ReadRepository<DirectoryClass>, IDirectoryClassReadRepository
    {
        public DirectoryClassReadRepository(CustomerRegistrationDirectoryAPIDbContext context) : base(context)
        {
        }
    }
}
