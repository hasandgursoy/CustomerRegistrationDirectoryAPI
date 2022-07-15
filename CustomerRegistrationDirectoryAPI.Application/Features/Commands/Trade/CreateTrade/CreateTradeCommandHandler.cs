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

        public CreateTradeCommandHandler(ITradeWriteRepository tradeWriteRepository)
        {
            _tradeWriteRepository = tradeWriteRepository;
        }

        public Task<CreateTradeCommandResponse> Handle(CreateTradeCommandRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
