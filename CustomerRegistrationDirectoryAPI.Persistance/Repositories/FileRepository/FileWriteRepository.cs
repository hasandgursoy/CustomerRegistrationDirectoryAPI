using CustomerRegistrationDirectoryAPI.Application.Repositories.FileRepository;
using CustomerRegistrationDirectoryAPI.Persistance.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerRegistrationDirectoryAPI.Persistance.Repositories.FileRepository
{
    public class FileWriteRepository : WriteRepository<Domain.Entities.File>, IFileWriteRepository
    {
        public FileWriteRepository(CustomerRegistrationDirectoryAPIDbContext context) : base(context)
        {
        }
    }
}
