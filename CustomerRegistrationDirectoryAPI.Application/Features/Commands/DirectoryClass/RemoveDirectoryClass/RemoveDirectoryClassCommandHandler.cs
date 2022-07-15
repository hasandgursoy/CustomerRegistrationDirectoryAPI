using CustomerRegistrationDirectoryAPI.Application.Repositories.DirectoryRepository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerRegistrationDirectoryAPI.Application.Features.Commands.DirectoryClass.RemoveDirectoryClass
{
    public class RemoveDirectoryClassCommandHandler : IRequestHandler<RemoveDirectoryClassCommandRequest, RemoveDirectoryClassCommandResponse>
    {
        readonly IDirectoryClassWriteRepository _directoryClassWriteRepository;

        public RemoveDirectoryClassCommandHandler(IDirectoryClassWriteRepository directoryClassWriteRepository)
        {
            _directoryClassWriteRepository = directoryClassWriteRepository;
        }

        public Task<RemoveDirectoryClassCommandResponse> Handle(RemoveDirectoryClassCommandRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
