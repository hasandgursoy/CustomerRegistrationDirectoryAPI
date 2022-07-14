using CustomerRegistrationDirectoryAPI.Application.Repositories.TradeRepository;
using CustomerRegistrationDirectoryAPI.Domain.Entities;
using CustomerRegistrationDirectoryAPI.Persistance.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerRegistrationDirectoryAPI.Persistance.Repositories.TradeRepository
{
    public class TradeWriteRepository : WriteRepository<Trade>, ITradeWriteRepository
    {
        public TradeWriteRepository(CustomerRegistrationDirectoryAPIDbContext context) : base(context)
        {
        }
    }
}
