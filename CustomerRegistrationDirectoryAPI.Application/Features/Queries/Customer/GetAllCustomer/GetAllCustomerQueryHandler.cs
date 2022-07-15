using AutoMapper;
using CustomerRegistrationDirectoryAPI.Application.Repositories.CustomerRepository;
using MediatR;
using Microsoft.EntityFrameworkCore;
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

        public async  Task<GetAllCustomerQueryResponse> Handle(GetAllCustomerQueryRequest request, CancellationToken cancellationToken)
        {
            var totalCount = _customerReadRepository.GetAll(false).Count();
            var customers = _customerReadRepository.GetAll(false).Select( p => new
            {
                p.Id,
                p.Name,
                p.Surname,
                p.PhoneNumber,
                p.Trades,
                p.City,
                p.Email,
                p.Directory
            });

            GetAllCustomerQueryResponse response = new();
            response.Customers = customers;
            response.TotalCount = totalCount;

            return response;

        }
    }
}
