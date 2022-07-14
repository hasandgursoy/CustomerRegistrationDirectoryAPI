using CustomerRegistrationDirectoryAPI.Domain.Entities;
using CustomerRegistrationDirectoryAPI.Domain.Entities.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerRegistrationDirectoryAPI.Persistance.Context
{
    public class CustomerRegistrationDirectoryAPIDbContext : DbContext
    {
        public CustomerRegistrationDirectoryAPIDbContext(DbContextOptions options) : base(options)
        {
            // IOC 'de dolduralacak
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<DirectoryClass> Directories { get; set; }
        public DbSet<Trade> Trades { get; set; }


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
