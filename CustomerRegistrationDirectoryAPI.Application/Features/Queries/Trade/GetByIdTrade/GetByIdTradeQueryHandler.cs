using CustomerRegistrationDirectoryAPI.Application.Repositories.TradeRepository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerRegistrationDirectoryAPI.Application.Features.Queries.Trade.GetByIdTrade
{
    public class GetByIdTradeQueryHandler : IRequestHandler<GetByIdTradeQueryRequest, GetByIdTradeQueryResponse>
    {
        readonly ITradeReadRepository _tradeReadRepository;

        public GetByIdTradeQueryHandler(ITradeReadRepository tradeReadRepository)
        {
            _tradeReadRepository = tradeReadRepository;
        }

        public Task<GetByIdTradeQueryResponse> Handle(GetByIdTradeQueryRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
