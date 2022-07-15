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

        public UploadTradeCommandHandler(ITradeWriteRepository tradeWriteRepository)
        {
            _tradeWriteRepository = tradeWriteRepository;
        }

        public Task<UploadTradeCommandResponse> Handle(UploadTradeCommandRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
