using CustomerRegistrationDirectoryAPI.Application.Repositories.TradeRepository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerRegistrationDirectoryAPI.Application.Features.Commands.Trade.RemoveTrade
{
    public class RemoveTradeCommandHandler : IRequestHandler<RemoveTradeCommandRequest, RemoveTradeCommandResponse>
    {

        readonly ITradeWriteRepository _tradeWriteRepository;
        readonly ITradeReadRepository _tradeReadRepository;

        public RemoveTradeCommandHandler(ITradeWriteRepository tradeWriteRepository, ITradeReadRepository tradeReadRepository)
        {
            _tradeWriteRepository = tradeWriteRepository;
            _tradeReadRepository = tradeReadRepository;
        }

        public async Task<RemoveTradeCommandResponse> Handle(RemoveTradeCommandRequest request, CancellationToken cancellationToken)
        {
            Domain.Entities.Trade trade = await _tradeReadRepository.GetByIdAsync(request.Id);
            _tradeWriteRepository.Remove(trade);
            await _tradeWriteRepository.SaveAsync();
            return new();
        }
    }
}
