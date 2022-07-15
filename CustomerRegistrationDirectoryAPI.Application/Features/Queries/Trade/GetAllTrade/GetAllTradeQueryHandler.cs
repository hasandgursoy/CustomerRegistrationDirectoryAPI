using CustomerRegistrationDirectoryAPI.Application.Repositories.TradeRepository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerRegistrationDirectoryAPI.Application.Features.Queries.Trade.GetAllTrade
{
    public class GetAllTradeQueryHandler : IRequestHandler<GetAllTradeQueryRequest, GetAllTradeQueryResponse>
    {
        readonly ITradeReadRepository _tradeReadRepository;

        public GetAllTradeQueryHandler(ITradeReadRepository tradeReadRepository)
        {
            _tradeReadRepository = tradeReadRepository;
        }

        public Task<GetAllTradeQueryResponse> Handle(GetAllTradeQueryRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
