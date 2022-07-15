using CustomerRegistrationDirectoryAPI.Application.Abstraction.Storage;
using CustomerRegistrationDirectoryAPI.Infrastructure.Storage;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerRegistrationDirectoryAPI.Infrastructure
{
    public static class ServiceRegistration
    {
        public static void AddInfrastructureServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IStorageService, StorageService>();

        }
        // IStorage'dan türemiş sınıf olmasını şart koşacağız. Çünkü azure aws ve local da yazdığımız kodlar tek class ismiyle program cs de değiştiirlmesini hedefliyoruz.
        public static void AddStorage<T>(this IServiceCollection serviceCollection) where T : Infrastructure.Storage.Storage, IStorage
        {
            serviceCollection.AddScoped<IStorage, T>();
        }

    }
}
