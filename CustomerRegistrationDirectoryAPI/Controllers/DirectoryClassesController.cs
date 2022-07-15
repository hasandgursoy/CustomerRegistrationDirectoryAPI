using CustomerRegistrationDirectoryAPI.Application.Features.Commands.DirectoryClass.CreateDirectoryClass;
using CustomerRegistrationDirectoryAPI.Application.Features.Commands.DirectoryClass.RemoveDirectoryClass;
using CustomerRegistrationDirectoryAPI.Application.Features.Commands.DirectoryClass.UploadDirectoryClass;
using CustomerRegistrationDirectoryAPI.Application.Features.Queries.DirectoryClass.GetAllDirectoryClass;
using CustomerRegistrationDirectoryAPI.Application.Features.Queries.DirectoryClass.GetByIdDirectoryClass;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CustomerRegistrationDirectoryAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = "Admin")]
    public class DirectoryClassesController : ControllerBase
    {
        IMediator _mediatr;

        public DirectoryClassesController(IMediator mediatr)
        {
            _mediatr = mediatr;
        }


        [HttpGet]
        public async Task<IActionResult> GetAll(GetAllDirectoryClassQueryRequest request)
        {
            var response = _mediatr.Send(request);
            return Ok();
        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> GetById([FromRoute] GetByIdDirectoryClassQueryRequest request)
        {
            var response = await _mediatr.Send(request);
            return Ok(response);
        }

        [HttpPost]

        public async Task<IActionResult> Post([FromBody] CreateDirectoryClassCommandRequest request)
        {
            await _mediatr.Send(request);
            return Ok();
        }

        [HttpPut]

        public async Task<IActionResult> Put([FromBody] UploadDirectoryClassCommandRequest request)
        {
            await _mediatr.Send(request);
            return Ok();
        }

        [HttpDelete("{Id}")]
        public async Task<IActionResult> Delete([FromRoute] RemoveDirectoryClassCommandRequest request)
        {
            await _mediatr.Send(request);
            return Ok();
        }
    }
}
