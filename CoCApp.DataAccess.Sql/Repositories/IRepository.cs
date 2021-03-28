using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CoCApp.DataAccess.Sql.Repositories
{
    public interface IRepository<T> where T: class
    {
        public Task<List<T>> GetAllAsync();
        public Task<T> GetAsync(Guid id);
        public Task<T> InsertAsync(Guid id);
        public Task SaveChangesAsync();
    }
}
