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

        public UploadDirectoryClassCommandHandler(IDirectoryClassWriteRepository directoryClassWriteRepository)
        {
            _directoryClassWriteRepository = directoryClassWriteRepository;
        }

        public Task<UploadDirectoryClassCommandResponse> Handle(UploadDirectoryClassCommandRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
