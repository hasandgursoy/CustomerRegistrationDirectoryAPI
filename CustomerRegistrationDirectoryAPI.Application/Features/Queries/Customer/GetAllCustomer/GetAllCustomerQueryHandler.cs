using CustomerRegistrationDirectoryAPI.Application.Repositories.CustomerRepository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerRegistrationDirectoryAPI.Application.Features.Queries.Customer.GetAllCustomer
{
    public class GetAllCustomerQueryHandler : IRequestHandler<GetAllCustomerQueryRequest, GetAllCustomerQueryResponse>
    {
        readonly ICustomerReadRepository _customerReadRepository;

        public GetAllCustomerQueryHandler(ICustomerReadRepository customerReadRepository)
        {
            _customerReadRepository = customerReadRepository;
        }

        public Task<GetAllCustomerQueryResponse> Handle(GetAllCustomerQueryRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
