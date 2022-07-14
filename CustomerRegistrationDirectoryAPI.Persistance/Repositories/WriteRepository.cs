using CustomerRegistrationDirectoryAPI.Application.Repositories;
using CustomerRegistrationDirectoryAPI.Domain.Entities.Common;
using CustomerRegistrationDirectoryAPI.Persistance.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerRegistrationDirectoryAPI.Persistance.Repositories
{
    public class WriteRepository<T> : IWriteRepository<T> where T : BaseEntity
    {
        readonly CustomerRegistrationDirectoryAPIDbContext _context;

        public WriteRepository(CustomerRegistrationDirectoryAPIDbContext context)
        {
            _context = context;
        }

        public DbSet<T> Table => _context.Set<T>();

        public async Task<bool> AddAsync(T data)
        {
            EntityEntry<T> entityEntry = await Table.AddAsync(data);
            return entityEntry.State == EntityState.Added;
        }

        public async Task<bool> AddRangeAsync(List<T> datas)
        {
            await Table.AddRangeAsync(datas);
            return true;
        }

        public bool Remove(T data)
        {
            EntityEntry<T> entityEntry = Table.Remove(data);
            return entityEntry.State == EntityState.Deleted;
        }

        public async Task<bool> RemoveAsync(string id)
        {
            T data = await Table.FirstOrDefaultAsync(data => data.Id == Guid.Parse(id));
            return Remove(data);
        }

        public bool RemoveRange(List<T> datas)
        {
           Table.RemoveRange(datas);
           return true;
        }

        public bool Update(T model)
        {
            EntityEntry entityEntry = Table.Update(model);
            return entityEntry.State == EntityState.Modified;
        }
        public async Task<int> SaveAsync()
            => await _context.SaveChangesAsync();
    }
}
