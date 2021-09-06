using CoCApp.DataAccess.Sql.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace CoCApp.DataAccess.Sql.Repositories
{
    public class Repository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        protected readonly AppDbContext context;

        public Repository(AppDbContext context)
        {
            this.context = context;
            if (context == null) throw new ArgumentNullException("The dbcontext is null!");
        }

        public async Task<TEntity> AddAsync(TEntity entity)
        {
            var result = await context.Set<TEntity>().AddAsync(entity);
            return result.Entity;
        }

        public Task<TEntity> AddRange(IEnumerable<TEntity> entities)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<TEntity>> FindAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await context.Set<TEntity>().Where(predicate).ToListAsync();
        }

        public async Task<TEntity> GetAsync(Guid id)
        {
            return await context.Set<TEntity>().FindAsync(id);
        }

        public Task<IEnumerable<TEntity>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public void Remove(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void RemoveRange(IEnumerable<TEntity> entities)
        {
            throw new NotImplementedException();
        }
    }
}
