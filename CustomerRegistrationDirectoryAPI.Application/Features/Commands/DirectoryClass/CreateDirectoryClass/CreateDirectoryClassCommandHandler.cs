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

        public CreateDirectoryClassCommandHandler(IDirectoryClassWriteRepository directoryClassWriteRepository)
        {
            _directoryClassWriteRepository = directoryClassWriteRepository;
        }

        public Task<CreateDirectoryClassCommandResponse> Handle(CreateDirectoryClassCommandRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
