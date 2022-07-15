using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerRegistrationDirectoryAPI.Application.Features.Commands.Trade.CreateTrade
{
    public class CreateTradeCommandRequest :IRequest<CreateTradeCommandResponse>
    {
        public Guid CustomerId { get; set; }
        public Domain.Entities.Customer Customer { get; set; }
        public string Description { get; set; }
        public decimal TradeVolume { get; set; }

    }
}
