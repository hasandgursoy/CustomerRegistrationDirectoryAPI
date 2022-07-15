using AutoMapper;
using CustomerRegistrationDirectoryAPI.Application.Repositories.TradeRepository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerRegistrationDirectoryAPI.Application.Features.Commands.Trade.CreateTrade
{
    public class CreateTradeCommandHandler : IRequestHandler<CreateTradeCommandRequest, CreateTradeCommandResponse>
    {
        readonly ITradeWriteRepository _tradeWriteRepository;
        readonly IMapper _mapper;
        public CreateTradeCommandHandler(ITradeWriteRepository tradeWriteRepository, IMapper mapper)
        {
            _tradeWriteRepository = tradeWriteRepository;
            _mapper = mapper;
        }

        public async Task<CreateTradeCommandResponse> Handle(CreateTradeCommandRequest request, CancellationToken cancellationToken)
        {
            await _tradeWriteRepository.AddAsync(_mapper.Map<Domain.Entities.Trade>(request));
            await _tradeWriteRepository.SaveAsync();
            return new();

        }



    }
}
