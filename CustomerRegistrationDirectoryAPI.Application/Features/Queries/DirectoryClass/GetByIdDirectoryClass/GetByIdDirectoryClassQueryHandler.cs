using AutoMapper;
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
        readonly IMapper _mapper;


        public GetByIdDirectoryClassQueryHandler(IDirectoryClassReadRepository directoryClassReadRepository, IMapper mapper)
        {
            _directoryClassReadRepository = directoryClassReadRepository;
            _mapper = mapper;
        }

        public async Task<GetByIdDirectoryClassQueryResponse> Handle(GetByIdDirectoryClassQueryRequest request, CancellationToken cancellationToken)
        {
            Domain.Entities.DirectoryClass directory = await _directoryClassReadRepository.GetByIdAsync(request.Id);
            return _mapper.Map<GetByIdDirectoryClassQueryResponse>(directory);
        }
    }
}
