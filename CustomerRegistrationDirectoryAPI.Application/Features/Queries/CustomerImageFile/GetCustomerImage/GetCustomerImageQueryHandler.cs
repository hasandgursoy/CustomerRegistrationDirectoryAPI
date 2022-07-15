using CustomerRegistrationDirectoryAPI.Application.Repositories.CustomerImageFileRepository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerRegistrationDirectoryAPI.Application.Features.Queries.CustomerImageFile.GetCustomerImage
{
    public class GetCustomerImageQueryHandler : IRequestHandler<GetCustomerImageQueryRequest, GetCustomerImageQueryResponse>
    {
        readonly ICustomerImageFileReadRepository _customerImageFileReadRepository;

        public GetCustomerImageQueryHandler(ICustomerImageFileReadRepository customerImageFileReadRepository)
        {
            _customerImageFileReadRepository = customerImageFileReadRepository;
        }

        public Task<GetCustomerImageQueryResponse> Handle(GetCustomerImageQueryRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
