using CustomerRegistrationDirectoryAPI.Domain.Entities;
using CustomerRegistrationDirectoryAPI.Domain.Entities.Common;
using CustomerRegistrationDirectoryAPI.Domain.Entities.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerRegistrationDirectoryAPI.Persistance.Context
{
    public class CustomerRegistrationDirectoryAPIDbContext : IdentityDbContext<AppUser, AppRole, string>
    {
        public CustomerRegistrationDirectoryAPIDbContext(DbContextOptions options) : base(options)
        {
            // IOC 'de dolduralacak
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<DirectoryClass> Directories { get; set; }
        public DbSet<Trade> Trades { get; set; }


        public DbSet<Domain.Entities.File> Files { get; set; }
        public DbSet<CustomerImageFile> CustomerImagefiles { get; set; }


        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            var datas = ChangeTracker.Entries<BaseEntity>();

            foreach (var data in datas)
            {
                _ = data.State switch
                {
                    EntityState.Added => data.Entity.CreatedDate = DateTime.UtcNow,
                    EntityState.Modified => data.Entity.UpdatedDate = DateTime.UtcNow,

                    _ => DateTime.UtcNow
                };
            }


            return base.SaveChangesAsync(cancellationToken);
        }

    }
}
