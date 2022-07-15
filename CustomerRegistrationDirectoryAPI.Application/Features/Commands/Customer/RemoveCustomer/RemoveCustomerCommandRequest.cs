using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerRegistrationDirectoryAPI.Application.Features.Commands.Customer.RemoveCustomer
{
    public class RemoveCustomerCommandRequest : IRequest<RemoveCustomerCommandResponse>
    {
        public string Id { get; set; }
    }
}
