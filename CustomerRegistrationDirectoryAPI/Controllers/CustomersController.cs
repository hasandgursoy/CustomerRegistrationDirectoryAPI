using CustomerRegistrationDirectoryAPI.Application.Features.Commands.Customer.CreateCustomer;
using CustomerRegistrationDirectoryAPI.Application.Features.Commands.Customer.RemoveCustomer;
using CustomerRegistrationDirectoryAPI.Application.Features.Commands.Customer.UpdateCustomer;
using CustomerRegistrationDirectoryAPI.Application.Features.Commands.CustomerImageFile.RemoveCustomerImage;
using CustomerRegistrationDirectoryAPI.Application.Features.Commands.CustomerImageFile.UploadCustomerImage;
using CustomerRegistrationDirectoryAPI.Application.Features.Queries.Customer.GetAllCustomer;
using CustomerRegistrationDirectoryAPI.Application.Features.Queries.Customer.GetByIdCustomer;
using CustomerRegistrationDirectoryAPI.Application.Features.Queries.CustomerImageFile.GetCustomerImage;
using CustomerRegistrationDirectoryAPI.Application.Repositories.CustomerRepository;
using CustomerRegistrationDirectoryAPI.Application.Repositories.DirectoryRepository;
using CustomerRegistrationDirectoryAPI.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CustomerRegistrationDirectoryAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = "Admin")]
    public class CustomersController : ControllerBase
    {
        IMediator _mediator;

        public CustomersController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll(GetAllCustomerQueryRequest request)
        {
            GetAllCustomerQueryResponse response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> Get([FromRoute] GetByIdCustomerQueryRequest request)
        {
            GetByIdCustomerQueryResponse response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpPut]

        public async Task<IActionResult> Put([FromBody] UpdateCustomerCommandRequest request)
        {
            await _mediator.Send(request);
            return Ok();
        }


        [HttpDelete("{Id}")]

        public async Task<IActionResult> Delete([FromRoute] RemoveCustomerCommandRequest request)
        {
            await _mediator.Send(request);
            return Ok();
        }




        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateCustomerCommandRequest request )
        {
            await _mediator.Send(request);
            return Ok();
        }


        [HttpPost("[action]")]
        public async Task<IActionResult> ImageUpload([FromBody] UploadCustomerImageFileCommandRequest request)
        {
            await _mediator.Send(request);
            return Ok();
        }

        [HttpGet("[action]/{Id}")]
        public async Task<IActionResult> GetCustomerImages([FromRoute] GetCustomerImageQueryRequest request)
        {
            List<GetCustomerImageQueryResponse> response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpDelete("[action]/{Id}")]
        public async Task<IActionResult> DeleteCustomerImage([FromRoute] RemoveCustomerImageFileCommandRequest request)
        {
            await _mediator.Send(request);
            return Ok();
        }

    }



}
