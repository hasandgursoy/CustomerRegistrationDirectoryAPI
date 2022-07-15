using AutoMapper;
using CustomerRegistrationDirectoryAPI.Application.Repositories.DirectoryRepository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerRegistrationDirectoryAPI.Application.Features.Commands.DirectoryClass.CreateDirectoryClass
{
    public class CreateDirectoryClassCommandHandler : IRequestHandler<CreateDirectoryClassCommandRequest, CreateDirectoryClassCommandResponse>
    {
        readonly IDirectoryClassWriteRepository _directoryClassWriteRepository;
        readonly IMapper _mapper;
        public CreateDirectoryClassCommandHandler(IDirectoryClassWriteRepository directoryClassWriteRepository, IMapper mapper)
        {
            _directoryClassWriteRepository = directoryClassWriteRepository;
            _mapper = mapper;
        }

        public async Task<CreateDirectoryClassCommandResponse> Handle(CreateDirectoryClassCommandRequest request, CancellationToken cancellationToken)
        {
            await _directoryClassWriteRepository.AddAsync(_mapper.Map<Domain.Entities.DirectoryClass>(request));
            await _directoryClassWriteRepository.SaveAsync();
            return new();
        }
    }
}
