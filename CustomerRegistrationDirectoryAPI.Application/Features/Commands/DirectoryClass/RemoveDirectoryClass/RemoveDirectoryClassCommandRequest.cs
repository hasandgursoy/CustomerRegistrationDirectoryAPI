using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerRegistrationDirectoryAPI.Application.Features.Commands.DirectoryClass.RemoveDirectoryClass
{
    public class RemoveDirectoryClassCommandRequest :IRequest<RemoveDirectoryClassCommandResponse>
    {
        public String Id { get; set; }

    }
}
