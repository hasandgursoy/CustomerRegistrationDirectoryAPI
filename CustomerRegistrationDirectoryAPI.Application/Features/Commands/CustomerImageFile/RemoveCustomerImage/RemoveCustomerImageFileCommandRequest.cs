using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerRegistrationDirectoryAPI.Application.Features.Commands.CustomerImageFile.RemoveCustomerImage
{
    public class RemoveCustomerImageFileCommandRequest :IRequest<RemoveCustomerImageFileCommandResponse>
    {
        public string Id { get; set; }
        public string? ImageId { get; set; }
    }
}
