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
        readonly IDirectoryClassReadRepository _directoryClassReadRepository;
        public RemoveDirectoryClassCommandHandler(IDirectoryClassWriteRepository directoryClassWriteRepository, IDirectoryClassReadRepository directoryClassReadRepository)
        {
            _directoryClassWriteRepository = directoryClassWriteRepository;
            _directoryClassReadRepository = directoryClassReadRepository;
        }

        public async Task<RemoveDirectoryClassCommandResponse> Handle(RemoveDirectoryClassCommandRequest request, CancellationToken cancellationToken)
        {
            Domain.Entities.DirectoryClass directory = await _directoryClassReadRepository.GetByIdAsync(request.Id);
            if (directory !=null)
            {
                _directoryClassWriteRepository.Remove(directory);
            }

            return new();
        }
    }
}
