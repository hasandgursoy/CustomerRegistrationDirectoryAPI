using CustomerRegistrationDirectoryAPI.Application.Repositories.FileRepository;
using CustomerRegistrationDirectoryAPI.Persistance.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerRegistrationDirectoryAPI.Persistance.Repositories.FileRepository
{
    public class FileReadRepository : ReadRepository<Domain.Entities.File>, IFileReadRepository
    {
        public FileReadRepository(CustomerRegistrationDirectoryAPIDbContext context) : base(context)
        {
        }
    }
}
