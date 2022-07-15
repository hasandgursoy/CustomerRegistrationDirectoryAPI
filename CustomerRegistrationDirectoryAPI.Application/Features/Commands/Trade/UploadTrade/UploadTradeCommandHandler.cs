using AutoMapper;
using CustomerRegistrationDirectoryAPI.Application.Repositories.TradeRepository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerRegistrationDirectoryAPI.Application.Features.Commands.Trade.UploadTrade
{
    public class UploadTradeCommandHandler : IRequestHandler<UploadTradeCommandRequest, UploadTradeCommandResponse>
    {
        readonly ITradeWriteRepository _tradeWriteRepository;
        readonly ITradeReadRepository _tradeReadRepository;
        readonly IMapper _mapper;
        public UploadTradeCommandHandler(ITradeWriteRepository tradeWriteRepository, IMapper mapper, ITradeReadRepository tradeReadRepository)
        {
            _tradeWriteRepository = tradeWriteRepository;
            _tradeReadRepository = tradeReadRepository;
            _mapper = mapper;
        }

        public async Task<UploadTradeCommandResponse> Handle(UploadTradeCommandRequest request, CancellationToken cancellationToken)
        {
            Domain.Entities.Trade trade = await _tradeReadRepository.GetByIdAsync(request.Id);
            if (trade is not null)
            {
                _tradeWriteRepository.Update(_mapper.Map<Domain.Entities.Trade>(request));

            }
            await _tradeWriteRepository.SaveAsync();
            return new();

        }
    }
}
