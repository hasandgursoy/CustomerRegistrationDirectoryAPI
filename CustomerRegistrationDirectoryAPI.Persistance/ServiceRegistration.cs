using CustomerRegistrationDirectoryAPI.Persistance.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerRegistrationDirectoryAPI.Persistance
{
    public static class ServiceRegistration
    {
       

        public static void AddPersistanceServices(this IServiceCollection services,IConfiguration _configuration)
        {

            services.AddDbContext<CustomerRegistrationDirectoryAPIDbContext>(
                options => options.UseNpgsql(_configuration.GetConnectionString("PostgreSQL"))
                );
        }

    }
}
