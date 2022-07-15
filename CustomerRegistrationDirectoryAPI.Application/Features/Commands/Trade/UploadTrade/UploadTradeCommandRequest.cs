using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerRegistrationDirectoryAPI.Application.Features.Commands.Trade.UploadTrade
{
    public class UploadTradeCommandRequest : IRequest<UploadTradeCommandResponse>
    {
        public string Id { get; set; }
        public Guid CustomerId { get; set; }
        public string Description { get; set; }
        public decimal TradeVolume { get; set; }
    }
}
