using AutoMapper;
using CustomerRegistrationDirectoryAPI.Application.Repositories.DirectoryRepository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerRegistrationDirectoryAPI.Application.Features.Commands.DirectoryClass.UploadDirectoryClass
{
    public class UploadDirectoryClassCommandHandler : IRequestHandler<UploadDirectoryClassCommandRequest, UploadDirectoryClassCommandResponse>
    {
        readonly IDirectoryClassWriteRepository _directoryClassWriteRepository;
        readonly IDirectoryClassReadRepository _directoryClassReadRepository;
        readonly IMapper _mapper;
        public UploadDirectoryClassCommandHandler(IDirectoryClassWriteRepository directoryClassWriteRepository, IDirectoryClassReadRepository directoryClassReadRepository, IMapper mapper)
        {
            _directoryClassWriteRepository = directoryClassWriteRepository;
            _directoryClassReadRepository = directoryClassReadRepository;
            _mapper = mapper;
        }

        public async Task<UploadDirectoryClassCommandResponse> Handle(UploadDirectoryClassCommandRequest request, CancellationToken cancellationToken)
        {
            Domain.Entities.DirectoryClass directory = await _directoryClassReadRepository.GetByIdAsync(request.Id);
            if (directory != null)
            {
                _directoryClassWriteRepository.Update(_mapper.Map<Domain.Entities.DirectoryClass>(request));
            }

            return new();


        }
    }
}
