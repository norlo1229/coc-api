using CoCApp.Domain.Entities;
using System.Threading.Tasks;

namespace CoCApp.DataAccess.Sql.Repositories
{
    public interface ICharacteristicsRepository : IGenericRepository<Characteristics>
    {
        public Task SetStrength(int value);
    }
}
