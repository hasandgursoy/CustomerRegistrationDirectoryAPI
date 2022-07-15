using CustomerRegistrationDirectoryAPI.Application.Repositories.DirectoryRepository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerRegistrationDirectoryAPI.Application.Features.Queries.DirectoryClass.GetByIdDirectoryClass
{
    public class GetByIdDirectoryClassQueryHandler : IRequestHandler<GetByIdDirectoryClassQueryRequest, GetByIdDirectoryClassQueryResponse>
    {

        readonly IDirectoryClassReadRepository _directoryClassReadRepository;

        public GetByIdDirectoryClassQueryHandler(IDirectoryClassReadRepository directoryClassReadRepository)
        {
            _directoryClassReadRepository = directoryClassReadRepository;
        }

        public Task<GetByIdDirectoryClassQueryResponse> Handle(GetByIdDirectoryClassQueryRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
