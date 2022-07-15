using CustomerRegistrationDirectoryAPI.Application.Repositories.CustomerImageFileRepository;
using CustomerRegistrationDirectoryAPI.Application.Repositories.CustomerRepository;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerRegistrationDirectoryAPI.Application.Features.Queries.CustomerImageFile.GetCustomerImage
{
    public class GetCustomerImageQueryHandler : IRequestHandler<GetCustomerImageQueryRequest, List<GetCustomerImageQueryResponse>>
    {
        readonly ICustomerReadRepository _customerReadRepository;

        public GetCustomerImageQueryHandler(ICustomerReadRepository customerReadRepository)
        {
            _customerReadRepository = customerReadRepository;
        }

        public async Task<List<GetCustomerImageQueryResponse>> Handle(GetCustomerImageQueryRequest request, CancellationToken cancellationToken)
        {
            Domain.Entities.Customer? customer = await _customerReadRepository.Table
                .Include(c => c.CustomerImageFiles).FirstOrDefaultAsync(c => c.Id == Guid.Parse(request.Id));
            return customer.CustomerImageFiles.Select(c => new GetCustomerImageQueryResponse
            {
                Id = c.Id,
                FileName = c.FileName,
                Path = c.Path
            }).ToList();

        }
    }
}
