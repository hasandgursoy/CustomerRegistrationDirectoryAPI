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
    }
}
