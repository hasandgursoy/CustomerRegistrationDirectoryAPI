using AutoMapper;
using CustomerRegistrationDirectoryAPI.Application.Features.Commands.Customer.CreateCustomer;
using CustomerRegistrationDirectoryAPI.Application.Features.Commands.Customer.RemoveCustomer;
using CustomerRegistrationDirectoryAPI.Application.Features.Commands.Customer.UpdateCustomer;
using CustomerRegistrationDirectoryAPI.Application.Features.Commands.DirectoryClass.CreateDirectoryClass;
using CustomerRegistrationDirectoryAPI.Application.Features.Commands.DirectoryClass.UploadDirectoryClass;
using CustomerRegistrationDirectoryAPI.Application.Features.Commands.Trade.CreateTrade;
using CustomerRegistrationDirectoryAPI.Application.Features.Commands.Trade.UploadTrade;
using CustomerRegistrationDirectoryAPI.Application.Features.Queries.Customer.GetAllCustomer;
using CustomerRegistrationDirectoryAPI.Application.Features.Queries.Customer.GetByIdCustomer;
using CustomerRegistrationDirectoryAPI.Application.Features.Queries.DirectoryClass.GetByIdDirectoryClass;
using CustomerRegistrationDirectoryAPI.Application.Features.Queries.Trade.GetByIdTrade;
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
            CreateMap<CreateTradeCommandRequest, Trade>();
            CreateMap<UploadTradeCommandRequest, Trade>();
            CreateMap<CreateDirectoryClassCommandRequest, DirectoryClass>();
            CreateMap<UploadDirectoryClassCommandRequest, DirectoryClass>();
            CreateMap<GetByIdCustomerQueryResponse, Customer>().ReverseMap();
            CreateMap<GetByIdDirectoryClassQueryResponse, DirectoryClass>().ReverseMap();
            CreateMap<GetByIdTradeQueryResponse, Trade>().ReverseMap();
        }
    }
}
