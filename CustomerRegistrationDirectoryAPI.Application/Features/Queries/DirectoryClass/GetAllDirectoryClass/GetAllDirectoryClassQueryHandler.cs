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

        public Task<GetAllDirectoryClassQueryResponse> Handle(GetAllDirectoryClassQueryRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
