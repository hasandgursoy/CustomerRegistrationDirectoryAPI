using MediatR;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerRegistrationDirectoryAPI.Application.Features.Commands.CustomerImageFile.UploadCustomerImage
{
    public class UploadCustomerImageFileCommandRequest : IRequest<UploadCustomerImageFileCommandResponse>
    {
        public string Id { get; set; }
        public IFormFileCollection FormCollection { get; set; }
    }
}
