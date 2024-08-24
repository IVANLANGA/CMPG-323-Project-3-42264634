using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TelemetryPortal.Data;

namespace TelemetryPortal.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly TechtrendsContext _context;
        protected readonly DbSet<T> _dbSet;

        //Basic constructor to connect to db
        public GenericRepository(TechtrendsContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        //Implementation of get all function
        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        //implementation of getting specified id function
        public async Task<T> GetByIdAsync(Guid id)
        {
            return await _dbSet.FindAsync(id);
        }

        //implementation of adding a new entity
        public async Task AddAsync(T entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));

            await _dbSet.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        //implementation of Updating an entity
        public async Task UpdateAsync(T entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));

            _dbSet.Update(entity);
            await _context.SaveChangesAsync();
        }

        //implementation of removing an entity function
        public async Task RemoveAsync(T entity)
        {
            _dbSet.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }
}
