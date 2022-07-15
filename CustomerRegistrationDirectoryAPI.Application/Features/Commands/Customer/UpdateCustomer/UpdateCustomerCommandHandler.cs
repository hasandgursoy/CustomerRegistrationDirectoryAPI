using AutoMapper;
using CustomerRegistrationDirectoryAPI.Application.Repositories.CustomerRepository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerRegistrationDirectoryAPI.Application.Features.Commands.Customer.UpdateCustomer
{
    public class UpdateCustomerCommandHandler : IRequestHandler<UpdateCustomerCommandRequest, UpdateCustomerCommandResponse>
    {
        readonly ICustomerWriteRepository _customerWriteRepository;
        readonly ICustomerReadRepository _customerReadRepository;
        readonly IMapper _mapper;

        public UpdateCustomerCommandHandler(ICustomerWriteRepository customerWriteRepository, IMapper mapper, ICustomerReadRepository customerReadRepository)
        {
            _customerWriteRepository = customerWriteRepository;
            _mapper = mapper;
            _customerReadRepository = customerReadRepository;
        }

        public async Task<UpdateCustomerCommandResponse> Handle(UpdateCustomerCommandRequest request, CancellationToken cancellationToken)
        {
            Domain.Entities.Customer customer = await _customerReadRepository.GetByIdAsync(request.Id);
            _customerWriteRepository.Update(_mapper.Map<Domain.Entities.Customer>(customer));
            await _customerWriteRepository.SaveAsync();
            return new();
        }
    }
}
