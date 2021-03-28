using System;
using System.Threading.Tasks;

namespace CoCApp.DataAccess.Sql.Repositories
{
    public interface IInspectorRepository
    {
        Task<Entities.Inspector> GetAsync(Guid id);
        Task Update(Entities.Inspector inspector);
        Task DeleteAsync(Guid id);
        Task<Entities.Inspector> Insert(Entities.Inspector inspector);
        Task SaveChangesAsync();
    }
}
