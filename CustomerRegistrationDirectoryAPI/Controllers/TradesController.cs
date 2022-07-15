using CustomerRegistrationDirectoryAPI.Application.Features.Commands.Trade.CreateTrade;
using CustomerRegistrationDirectoryAPI.Application.Features.Commands.Trade.RemoveTrade;
using CustomerRegistrationDirectoryAPI.Application.Features.Commands.Trade.UploadTrade;
using CustomerRegistrationDirectoryAPI.Application.Features.Queries.Trade.GetAllTrade;
using CustomerRegistrationDirectoryAPI.Application.Features.Queries.Trade.GetByIdTrade;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CustomerRegistrationDirectoryAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TradesController : ControllerBase
    {
        IMediator _mediatr;

        public TradesController(IMediator mediatr)
        {
            _mediatr = mediatr;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll(GetAllTradeQueryRequest request)
        {
            var response = _mediatr.Send(request);
            return Ok(response);
        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> GetById([FromRoute] GetByIdTradeQueryRequest request)
        {
            var response = _mediatr.Send(request);
            return Ok(response);
        }


        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateTradeCommandRequest request)
        {
            await _mediatr.Send(request);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Put([FromBody] UploadTradeCommandRequest request)
        {
            await _mediatr.Send(request);
            return Ok();
        }

        [HttpDelete("{Id}")]

        public async Task<IActionResult> Delete([FromRoute] RemoveTradeCommandRequest request)
        {
            await _mediatr.Send(request);
            return Ok();
        }

    }
}
