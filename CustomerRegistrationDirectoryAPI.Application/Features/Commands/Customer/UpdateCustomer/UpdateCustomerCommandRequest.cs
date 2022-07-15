using CustomerRegistrationDirectoryAPI.Domain.Entities.Common;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerRegistrationDirectoryAPI.Application.Features.Commands.Customer.UpdateCustomer
{
    public class UpdateCustomerCommandRequest : IRequest<UpdateCustomerCommandResponse>
    {
        public string Id { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string? City { get; set; }
        public Guid DirectoryId { get; set; }

    }
}
