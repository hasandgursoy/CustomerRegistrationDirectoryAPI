using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerRegistrationDirectoryAPI.Application.Features.Commands.DirectoryClass.UploadDirectoryClass
{
    public class UploadDirectoryClassCommandRequest : IRequest<UploadDirectoryClassCommandResponse>
    {
        public string Id { get; set; }
        public string Name { get; set; }

    }
}
