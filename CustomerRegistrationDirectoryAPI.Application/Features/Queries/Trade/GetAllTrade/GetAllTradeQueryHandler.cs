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

        public async Task<GetAllTradeQueryResponse> Handle(GetAllTradeQueryRequest request, CancellationToken cancellationToken)
        {
            var totalCount = _tradeReadRepository.GetAll(false).Count();
            var trades = _tradeReadRepository.GetAll(false).Select( p => new
            {
                p.Id,
                p.Customer,
                p.Description,
                p.CustomerId,
                p.TradeVolume,
                
            }).ToList();

            return new()
            {
                TotalCount = totalCount,
                Trades = trades
            };
        
        }
    }
}
