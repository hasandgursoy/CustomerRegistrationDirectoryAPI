using CustomerRegistrationDirectoryAPI.Application.Repositories.CustomerImageFileRepository;
using CustomerRegistrationDirectoryAPI.Application.Repositories.CustomerRepository;
using CustomerRegistrationDirectoryAPI.Application.Repositories.DirectoryRepository;
using CustomerRegistrationDirectoryAPI.Application.Repositories.FileRepository;
using CustomerRegistrationDirectoryAPI.Application.Repositories.TradeRepository;
using CustomerRegistrationDirectoryAPI.Persistance.Context;
using CustomerRegistrationDirectoryAPI.Persistance.Repositories.CustomerImageFileRepository;
using CustomerRegistrationDirectoryAPI.Persistance.Repositories.CustomerRepository;
using CustomerRegistrationDirectoryAPI.Persistance.Repositories.DirectoryRepository;
using CustomerRegistrationDirectoryAPI.Persistance.Repositories.FileRepository;
using CustomerRegistrationDirectoryAPI.Persistance.Repositories.TradeRepository;
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
                options => options.UseNpgsql(_configuration.GetConnectionString("PostgreSQL")));
            services.AddScoped<ICustomerReadRepository, CustomerReadRepository>();
            services.AddScoped<ICustomerWriteRepository, CustomerWriteRepository>();
            services.AddScoped<ITradeReadRepository, TradeReadRepository>();
            services.AddScoped<ITradeWriteRepository, TradeWriteRepository>();
            services.AddScoped<ICustomerImageFileReadRepository, CustomerImageFileReadRepository>();
            services.AddScoped<ICustomerImageFileWriteRepository, CustomerImageFileWriteRepository>();
            services.AddScoped<IDirectoryClassReadRepository, DirectoryClassReadRepository>();
            services.AddScoped<IDirectoryClassWriteRepository, DirectoryClassWriteRepository>();
            services.AddScoped<IFileReadRepository, FileReadRepository>();
            services.AddScoped<IFileWriteRepository, FileWriteRepository>();

        }



    }
}
