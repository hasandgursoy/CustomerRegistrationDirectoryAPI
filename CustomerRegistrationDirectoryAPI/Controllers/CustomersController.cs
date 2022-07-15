using CustomerRegistrationDirectoryAPI.Application.Repositories.CustomerRepository;
using CustomerRegistrationDirectoryAPI.Application.Repositories.DirectoryRepository;
using CustomerRegistrationDirectoryAPI.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CustomerRegistrationDirectoryAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {

        readonly ICustomerReadRepository _customerReadRepository;
        readonly ICustomerWriteRepository _customerWriteRepository;
        readonly IDirectoryClassWriteRepository _directoryWriteRepository;
        public CustomersController(ICustomerReadRepository customerReadRepository, ICustomerWriteRepository customerWriteRepository, IDirectoryClassWriteRepository directoryWriteRepository)
        {
            _customerReadRepository = customerReadRepository;
            _customerWriteRepository = customerWriteRepository;
            _directoryWriteRepository = directoryWriteRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
           var datas =  _customerReadRepository.GetAll();

            return Ok(datas);
        }

        [HttpPost]
        public async Task<IActionResult> Upload( )
        {
            
            return Ok();
        }


        [HttpPost("[action]")]
        public async Task<IActionResult> DirectoryPost()
        {
            
            return Ok();
        }

    }



}
