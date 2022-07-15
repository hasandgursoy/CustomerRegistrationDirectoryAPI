using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerRegistrationDirectoryAPI.Application.Features.Queries.Customer.GetAllCustomer
{
    public class GetAllCustomerQueryRequest : IRequest<GetAllCustomerQueryResponse>
    {
    }
}
