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

        public RemoveTradeCommandHandler(ITradeWriteRepository tradeWriteRepository)
        {
            _tradeWriteRepository = tradeWriteRepository;
        }

        public Task<RemoveTradeCommandResponse> Handle(RemoveTradeCommandRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
