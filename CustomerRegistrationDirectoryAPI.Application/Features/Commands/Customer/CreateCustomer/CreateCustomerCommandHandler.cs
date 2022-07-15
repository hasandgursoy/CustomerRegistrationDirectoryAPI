using AutoMapper;
using CustomerRegistrationDirectoryAPI.Application.Repositories.CustomerRepository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerRegistrationDirectoryAPI.Application.Features.Commands.Customer.CreateCustomer
{
    public class CreateCustomerCommandHandler : IRequestHandler<CreateCustomerCommandRequest, CreateCustomerCommandResponse>
    {
        readonly ICustomerWriteRepository _customerWriteRepository;
        readonly IMapper _mapper;

        public CreateCustomerCommandHandler(ICustomerWriteRepository customerWriteRepository, IMapper mapper)
        {
            _customerWriteRepository = customerWriteRepository;
            _mapper = mapper;
        }

        public async Task<CreateCustomerCommandResponse> Handle(CreateCustomerCommandRequest request, CancellationToken cancellationToken)
        {
            await _customerWriteRepository.AddAsync(_mapper.Map<Domain.Entities.Customer>(request));
            await _customerWriteRepository.SaveAsync();

            return new();

        }
    }
}
