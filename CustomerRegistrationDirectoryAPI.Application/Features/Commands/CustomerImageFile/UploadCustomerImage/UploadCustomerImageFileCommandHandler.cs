using CustomerRegistrationDirectoryAPI.Application.Abstraction.Storage;
using CustomerRegistrationDirectoryAPI.Application.Repositories.CustomerImageFileRepository;
using CustomerRegistrationDirectoryAPI.Application.Repositories.CustomerRepository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerRegistrationDirectoryAPI.Application.Features.Commands.CustomerImageFile.UploadCustomerImage
{
    public class UploadCustomerImageFileCommandHandler : IRequestHandler<UploadCustomerImageFileCommandRequest, UploadCustomerImageFileCommandResponse>
    {
        readonly ICustomerImageFileWriteRepository _customerImageFileWriteRepository;
        readonly ICustomerReadRepository _customerReadRepository;
        readonly IStorageService _storageService;
        public UploadCustomerImageFileCommandHandler(ICustomerImageFileWriteRepository customerImageFileWriteRepository, ICustomerReadRepository customerReadRepository, IStorageService storageService)
        {
            _customerImageFileWriteRepository = customerImageFileWriteRepository;
            _customerReadRepository = customerReadRepository;
            _storageService = storageService;
        }

        public async Task<UploadCustomerImageFileCommandResponse> Handle(UploadCustomerImageFileCommandRequest request, CancellationToken cancellationToken)
        {
            List<(string fileName, string pathOrContainerName)> result = await _storageService.UploadAsync("photo-images", request.FormCollection);
            Domain.Entities.Customer customer = await _customerReadRepository.GetByIdAsync(request.Id);
            await _customerImageFileWriteRepository.AddRangeAsync(result.Select(d => 
            new Domain.Entities.CustomerImageFile()
            {
                FileName = d.fileName,
                Path = d.pathOrContainerName,
                Storage = _storageService.StorageName

            }).ToList());
            await _customerImageFileWriteRepository.SaveAsync();
            return new();

        }
    }
}
