using CustomerRegistrationDirectoryAPI.Application.Repositories.DirectoryRepository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerRegistrationDirectoryAPI.Application.Features.Queries.DirectoryClass.GetAllDirectoryClass
{
    public class GetAllDirectoryClassQueryHandler : IRequestHandler<GetAllDirectoryClassQueryRequest, GetAllDirectoryClassQueryResponse>
    {
        readonly IDirectoryClassReadRepository _directoryClassReadRepository;

        public GetAllDirectoryClassQueryHandler(IDirectoryClassReadRepository directoryClassReadRepository)
        {
            _directoryClassReadRepository = directoryClassReadRepository;
        }

        public async Task<GetAllDirectoryClassQueryResponse> Handle(GetAllDirectoryClassQueryRequest request, CancellationToken cancellationToken)
        {
            var totalCount = _directoryClassReadRepository.GetAll(false).Count();
            var directorys = _directoryClassReadRepository.GetAll(false).Select(p => new
            {
                p.Name,
                p.Id,
                p.Customer,
                
            }).ToList();

            return new()
            {
                TotalCount = totalCount,
                Directories = directorys
            };

        }


    }
}
