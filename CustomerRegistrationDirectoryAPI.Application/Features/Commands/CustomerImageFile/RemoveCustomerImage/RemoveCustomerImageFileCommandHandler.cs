using CustomerRegistrationDirectoryAPI.Application.Repositories.CustomerImageFileRepository;
using CustomerRegistrationDirectoryAPI.Application.Repositories.CustomerRepository;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerRegistrationDirectoryAPI.Application.Features.Commands.CustomerImageFile.RemoveCustomerImage
{
    public class RemoveCustomerImageFileCommandHandler : IRequestHandler<RemoveCustomerImageFileCommandRequest, RemoveCustomerImageFileCommandResponse>
    {
        readonly ICustomerImageFileWriteRepository _customerImageFileWriteRepository;
        readonly ICustomerReadRepository _customerReadRepository;

        public RemoveCustomerImageFileCommandHandler(ICustomerImageFileWriteRepository customerImageFileWriteRepository, ICustomerReadRepository customerReadRepository)
        {
            _customerImageFileWriteRepository = customerImageFileWriteRepository;
            _customerReadRepository = customerReadRepository;
        }

        public async Task<RemoveCustomerImageFileCommandResponse> Handle(RemoveCustomerImageFileCommandRequest request, CancellationToken cancellationToken)
        {
            Domain.Entities.Customer? customer = await _customerReadRepository.Table.Include(c => c.CustomerImageFiles)
                .FirstOrDefaultAsync(c => c.Id == Guid.Parse(request.Id));
            Domain.Entities.CustomerImageFile? customerImageFile = customer?.CustomerImageFiles
                .FirstOrDefault(p => p.Id == Guid.Parse(request.ImageId));

            if (customerImageFile != null)
            {
                customer?.CustomerImageFiles.Remove(customerImageFile);
            }

            await _customerImageFileWriteRepository.SaveAsync();
            return new();

        }
    }
}