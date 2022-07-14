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
        

        public CustomersController(DbSet<Customer> customers)
        {
            
        }



    }
}
