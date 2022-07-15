using AutoMapper;
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
        readonly IMapper _mapper;



        public GetByIdTradeQueryHandler(ITradeReadRepository tradeReadRepository, IMapper mapper)
        {
            _tradeReadRepository = tradeReadRepository;
            _mapper = mapper;
        }

        public async Task<GetByIdTradeQueryResponse> Handle(GetByIdTradeQueryRequest request, CancellationToken cancellationToken)
        {
            Domain.Entities.Trade trade = await _tradeReadRepository.GetByIdAsync(request.Id);
            return _mapper.Map<GetByIdTradeQueryResponse>(trade);
        }
    }
}
