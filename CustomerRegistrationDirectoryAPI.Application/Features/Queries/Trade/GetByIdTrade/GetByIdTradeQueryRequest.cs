using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerRegistrationDirectoryAPI.Application.Features.Queries.Trade.GetByIdTrade
{
    public class GetByIdTradeQueryRequest : IRequest<GetByIdTradeQueryResponse>
    {
        public string Id { get; set; }

    }
}
