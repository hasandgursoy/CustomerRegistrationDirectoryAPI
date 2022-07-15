using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerRegistrationDirectoryAPI.Application.Features.Queries.DirectoryClass.GetByIdDirectoryClass
{
    public class GetByIdDirectoryClassQueryRequest : IRequest<GetByIdDirectoryClassQueryResponse>
    {
        public string Id { get; set; }
    }
}
