using AutoMapper;
using CustomerRegistrationDirectoryAPI.Application.Features.Commands.Customer.CreateCustomer;
using CustomerRegistrationDirectoryAPI.Application.Features.Commands.Customer.RemoveCustomer;
using CustomerRegistrationDirectoryAPI.Application.Features.Commands.Customer.UpdateCustomer;
using CustomerRegistrationDirectoryAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerRegistrationDirectoryAPI.Application.Mapping
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<CreateCustomerCommandRequest, Customer>();
            CreateMap<UpdateCustomerCommandRequest, Customer>();

        }
    }
}
