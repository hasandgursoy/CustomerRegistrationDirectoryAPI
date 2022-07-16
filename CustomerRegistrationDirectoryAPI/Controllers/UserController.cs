using CustomerRegistrationDirectoryAPI.Application.Features.Commands.AppUser.CreateUser;
using CustomerRegistrationDirectoryAPI.Application.Features.Commands.AppUser.LoginUser;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CustomerRegistrationDirectoryAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        readonly IMediator _meditaor;

        public UserController(IMediator meditaor)
        {
            _meditaor = meditaor;
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser([FromBody] CreateUserCommandRequest createUserCommandRequest)
        {
            CreateUserCommandResponse response = await _meditaor.Send(createUserCommandRequest);
            return Ok(response);
        }

        [HttpPost("[action]")]

        public async Task<IActionResult> Login(LoginUserCommandRequest loginUserCommandRequest)
        {
            LoginUserCommandResponse response = await _meditaor.Send(loginUserCommandRequest);

            return Ok(response);
        }
    }
}
