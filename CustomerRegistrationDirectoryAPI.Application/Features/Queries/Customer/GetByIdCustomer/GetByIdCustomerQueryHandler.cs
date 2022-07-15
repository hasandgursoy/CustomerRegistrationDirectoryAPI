using CustomerRegistrationDirectoryAPI.Application.Repositories.CustomerRepository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerRegistrationDirectoryAPI.Application.Features.Queries.Customer.GetByIdCustomer
{
    public class GetByIdCustomerQueryHandler : IRequestHandler<GetByIdCustomerQueryRequest, GetByIdCustomerQueryResponse>
    {
        readonly ICustomerReadRepository _customerReadRepository;

        public GetByIdCustomerQueryHandler(ICustomerReadRepository customerReadRepository)
        {
            _customerReadRepository = customerReadRepository;
        }

        public Task<GetByIdCustomerQueryResponse> Handle(GetByIdCustomerQueryRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
